using Autossential.Activities.Properties;
using System.Activities;
using System.Data;

namespace Autossential.Activities
{
    public class TransposeData : CodeActivity
    {
        public InArgument<DataTable> InputDataTable { get; set; }
        public OutArgument<DataTable> OutputDataTable { get; set; }


        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            if (InputDataTable == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(InputDataTable)));
            if (OutputDataTable == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(OutputDataTable)));
        }

        protected override void Execute(CodeActivityContext context)
        {
            var input = InputDataTable.Get(context);
            var rowsCount = input.Rows.Count;

            var output = new DataTable();

            for (int i = 0; i <= rowsCount; i++)
                output.Columns.Add("Col" + (i + 1));

            foreach (DataColumn col in input.Columns)
            {
                var row = output.NewRow();
                row[0] = col.ColumnName;

                for (int i = 0; i < rowsCount; i++)
                    row[i + 1] = input.Rows[i][col.Ordinal];

                output.Rows.Add(row);
            }

            OutputDataTable.Set(context, output);
        }
    }
}
