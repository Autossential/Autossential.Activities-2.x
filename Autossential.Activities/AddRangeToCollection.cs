using Autossential.Activities.Properties;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Autossential.Activities
{
    public sealed class AddRangeToCollection<T> : CodeActivity
    {
        public InArgument<ICollection<T>> Collection { get; set; }
        public InArgument<IEnumerable<T>> Items { get; set; }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            if (Collection == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(Collection)));
            if (Items == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(Items)));

            var runtimeArgs = new Collection<RuntimeArgument>();

            var arg1 = new RuntimeArgument(nameof(Collection), typeof(ICollection<T>), ArgumentDirection.In, true);
            var arg2 = new RuntimeArgument(nameof(Items), typeof(IEnumerable<T>), ArgumentDirection.In, true);

            metadata.Bind(Collection, arg1);
            metadata.Bind(Items, arg2);

            runtimeArgs.Add(arg1);
            runtimeArgs.Add(arg2);

            metadata.SetArgumentsCollection(runtimeArgs);
        }

        protected override void Execute(CodeActivityContext context)
        {
            var data = Collection.Get(context);
            if (data == null)
                throw new Exception(Resources.AddRangeToCollection_ErrorMsg_CollectionNull);

            var items = Items.Get(context);
            if (items == null)
                throw new Exception(Resources.AddRangeToCollection_ErrorMsg_ItemsNull);

            foreach (var item in items)
                data.Add(item);
        }
    }
}