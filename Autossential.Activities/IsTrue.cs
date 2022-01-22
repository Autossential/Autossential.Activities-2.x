using Autossential.Activities.Properties;
using System.Activities;

namespace Autossential.Activities
{
    public sealed class IsTrue : CodeActivity<bool>
    {
        public InArgument<bool> Value { get; set; }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            if (Value == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(Value)));
        }

        protected override bool Execute(CodeActivityContext context)
        {
            return Value.Get(context);
        }
    }
}
