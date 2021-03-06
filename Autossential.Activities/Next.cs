using Autossential.Activities.Properties;
using Autossential.Shared.Activities.Constraints;
using System.Activities;

namespace Autossential.Activities
{
    public sealed class Next : NativeActivity
    {
        protected override bool CanInduceIdle => true;

        public InArgument<bool> Condition { get; set; }

        public Next()
        {
            ActivityConstraints.CreateConstraint<Next, Iterate>(Resources.Validation_ScopeErrorFormat(nameof(Iterate)));
        }

        protected override void Execute(NativeActivityContext context)
        {
            if (Condition.Expression != null && !Condition.Get(context))
                return;

            var bookmark = (Bookmark)context.Properties.Find(BOOKMARK_NAME);
            if (bookmark != null)
            {
                var value = context.CreateBookmark();
                _ = context.ResumeBookmark(bookmark, value);
            }
        }

        public const string BOOKMARK_NAME = "NextBookmark";
    }
}