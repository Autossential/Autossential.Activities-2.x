using Autossential.Activities.Properties;
using System;
using System.Activities;
using System.Data;
using System.Linq;

namespace Autossential.Activities
{
    public class ExtractDataColumnValues<T> : CodeActivity<T[]>
    {
        public InArgument<DataTable> DataTable { get; set; }
        public InArgument Column { get; set; }
        public InArgument<T> DefaultValue { get; set; }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            if (DataTable == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(DataTable)));
            if (Result == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(Result)));
            if (Column != null)
            {
                var argType = Column.ArgumentType;
                if (typeof(int).IsAssignableFrom(argType) || typeof(string).IsAssignableFrom(argType))
                {
                    var arg = new RuntimeArgument(nameof(Column), argType, ArgumentDirection.In, false);
                    metadata.Bind(Column, arg);
                    metadata.AddArgument(arg);
                }
                else
                {
                    metadata.AddValidationError(Resources.Validation_TypeErrorFormat("int or string", nameof(Column)));
                }
            }
            else
            {
                metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(Column)));
            }
        }

        protected override T[] Execute(CodeActivityContext context)
        {
            var dt = DataTable.Get(context);
            var col = Column.Get(context);

            int index = 0;
            if (col is string colName)
                index = dt.Columns[colName].Ordinal;
            else
                index = (int)col;

            var values = dt.AsEnumerable().Select(row => row[index]).ToArray();
            var result = ConvertValues(values, DefaultValue.Get(context));
            return result;
        }

        private static T[] ConvertValues(object[] values, T defaultValue = default)
        {
            if (values.Length == 0)
                return new T[0];

            var result = new T[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == DBNull.Value)
                {
                    result[i] = defaultValue;
                    continue;
                }

                try
                {
                    result[i] = (T)values[i];
                }
                catch (InvalidCastException)
                {
                    try
                    {
                        result[i] = (T)Convert.ChangeType(values[i], typeof(T));
                    }
                    catch (Exception)
                    {
                        result[i] = defaultValue;
                    }
                }
                catch (Exception)
                {
                    result[i] = defaultValue;
                }
            }

            return result;
        }
    }
}