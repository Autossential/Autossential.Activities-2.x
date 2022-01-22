using Autossential.Activities.Properties;
using Autossential.Shared.Activities.Base;
using System;
using System.Activities;
using System.Activities.Validation;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Autossential.Activities
{
    public sealed class WaitDynamicFile : ContinuableAsyncTaskCodeActivity
    {
        public InArgument<string> DirectoryPath { get; set; }
        public InArgument<string> SearchPattern { get; set; }
        public InArgument<DateTime> AfterCreationTime { get; set; }
        public InArgument<int> Timeout { get; set; } = 30000;
        public int Interval { get; set; } = 500;
        public OutArgument<FileInfo> FileInfo { get; set; }

        private const int MINIMUM_INTERVAL = 100;
        private const int MAXIMUM_INTERVAL = 30000;

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);

            if (DirectoryPath == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(DirectoryPath)));
            if (Interval < MINIMUM_INTERVAL || Interval > MAXIMUM_INTERVAL)
                metadata.AddValidationError(new ValidationError(Resources.WaitFile_ErrorMsg_IntervalRangeFormat(MINIMUM_INTERVAL, MAXIMUM_INTERVAL)));

            if (FileInfo == null) metadata.AddValidationError(Resources.Validation_ValueErrorFormat(nameof(FileInfo)));
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken token)
        {
            var dir = DirectoryPath.Get(context);
            var time = Timeout.Get(context);
            var searchPattern = SearchPattern.Get(context);
            var afterDate = DateTime.Now;
            if (AfterCreationTime != null)
                afterDate = AfterCreationTime.Get(context);
            var filePath = await ExecuteWithTimeoutAsync(context, token, ExecuteMainAsync(dir, searchPattern, afterDate, token), time).ConfigureAwait(false);
            return ctx => FileInfo.Set(ctx, filePath != null ? new FileInfo(filePath) : null);
        }

        private Task<string> ExecuteMainAsync(string dir, string searchPattern, DateTime afterDate, CancellationToken token)
        {
            var interval = GetInterval();
            return Task.Run(() =>
            {
                do
                {
                    if (token.IsCancellationRequested)
                        token.ThrowIfCancellationRequested();

                    var files = Directory.EnumerateFiles(dir, searchPattern).Where(path => File.GetCreationTime(path) > afterDate);
                    if (files.Any())
                        return files.FirstOrDefault();

                    Thread.Sleep(interval);
                } while (true);
            });
        }

        private int GetInterval()
        {
            return Interval < 100 ? 100 : Math.Min(Interval, 30000);
        }
    }
}