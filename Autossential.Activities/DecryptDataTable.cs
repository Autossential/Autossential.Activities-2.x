using Autossential.Activities.Base;

using Autossential.Activities.Properties;
using Autossential.Core.Security;

using Autossential.Shared.Utils;
using System;
using System.Activities;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Autossential.Activities
{
    public sealed class DecryptDataTable : CryptographyBaseActivity
    {
        public InArgument<DataTable> InputDataTable { get; set; }
        public OutArgument<DataTable> OutputDataTable { get; set; }
        public InArgument Columns { get; set; }
        public InArgument<string> Sort { get; set; }
        public bool ParallelProcessing { get; set; } = true;

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            if (InputDataTable == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(InputDataTable)));
            if (OutputDataTable == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(OutputDataTable)));
            if (Columns != null)
            {
                var argType = Columns.ArgumentType;
                if (typeof(IEnumerable<int>).IsAssignableFrom(argType) || typeof(IEnumerable<string>).IsAssignableFrom(argType))
                {
                    var arg = new RuntimeArgument(nameof(Columns), argType, ArgumentDirection.In, false);
                    metadata.Bind(Columns, arg);
                    metadata.AddArgument(arg);
                }
                else
                {
                    metadata.AddValidationError(Resources.Validation_TypeErrorFormat("IEnumerable<string> or IEnumerable<int>", nameof(Columns)));
                }
            }
        }

        protected override void Execute(CodeActivityContext context)
        {
            var inputDt = InputDataTable.Get(context);
            var sortBy = Sort.Get(context);
            var columns = DataTableUtil.IdentifyDataColumns(inputDt, Columns?.Get(context), Enumerable.Range(0, inputDt.Columns.Count));

            var outputDt = CreateCryptoDataTable(inputDt, new HashSet<int>(columns));

            ExecuteCrypto(context, (crypto, key) =>
            {
                outputDt.BeginLoadData();
                AddToDataTable(inputDt, outputDt, key, crypto, columns);
                outputDt.AcceptChanges();
                outputDt.EndLoadData();
            });

            if (sortBy != null)
            {
                outputDt.DefaultView.Sort = sortBy;
                outputDt = outputDt.DefaultView.ToTable();
            }

            OutputDataTable.Set(context, outputDt);
        }

        private void AddToDataTable(DataTable inDt, DataTable outDt, string key, Crypto crypto, IEnumerable<int> dataColumnsIndex)
        {
            if (ParallelProcessing)
            {
                var safeList = new ConcurrentBag<object[]>();
                Parallel.ForEach(inDt.AsEnumerable(), row =>
                {
                    var values = ApplyDecryption(row.ItemArray, dataColumnsIndex, crypto, key);
                    safeList.Add(values);
                });

                while (!safeList.IsEmpty)
                {
                    if (safeList.TryTake(out object[] values))
                        outDt.LoadDataRow(values, false);
                }

                return;
            }

            foreach (DataRow row in inDt.Rows)
            {
                var values = ApplyDecryption(row.ItemArray, dataColumnsIndex, crypto, key);
                outDt.LoadDataRow(values, false);
            }
        }

        private object[] ApplyDecryption(object[] values, IEnumerable<int> dataColumnsIndex, Crypto crypto, string key)
        {
            foreach (var colIndex in dataColumnsIndex)
            {
                var content = values[colIndex];
                if (content == null || content == DBNull.Value || Equals(content, ""))
                    continue;

                values[colIndex] = crypto.Decrypt(content.ToString(), key);
            }

            return values;
        }
    }
}