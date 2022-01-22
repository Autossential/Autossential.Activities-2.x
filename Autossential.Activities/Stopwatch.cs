using Autossential.Activities.Properties;
using Autossential.Core.Enums;

using System.Activities;

namespace Autossential.Activities
{
    public sealed class Stopwatch : CodeActivity
    {
        public InOutArgument<System.Diagnostics.Stopwatch> StopwatchObj { get; set; }

        public StopwatchMethods Method { get; set; }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            if (StopwatchObj == null)
                metadata.AddValidationError(Resources.Validation_ValueErrorFormat(Resources.Stopwatch_StopwatchObj_DisplayName));
        }

        protected override void Execute(CodeActivityContext context)
        {
            var obj = StopwatchObj.Get(context) ?? new System.Diagnostics.Stopwatch();

            switch (Method)
            {
                case StopwatchMethods.Start:
                    obj.Start();
                    break;

                case StopwatchMethods.Stop:
                    obj.Stop();
                    break;

                case StopwatchMethods.Reset:
                    obj.Reset();
                    break;

                case StopwatchMethods.Restart:
                    obj.Restart();
                    break;
            }

            StopwatchObj.Set(context, obj);
        }
    }
}