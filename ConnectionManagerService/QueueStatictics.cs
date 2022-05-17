using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCompilerSettingsModels
{
    public class QueueStatictics
    {
        private Queue<FileSystemEventArgs> _queue;
        public QueueStatictics(Queue<FileSystemEventArgs> queue)
        {
            this._queue = queue;
        }

        public int FilesInQueue
        {
            get
            {
                return _queue != null ? _queue.Count : -1;
            }
        }
        public int CompiledFilesSuccessful { get; set; }
        public int FilesWithErrorCompile { get; set; }
        public int PercentOfSuccess
        {
            get
            {
                return FilesWithErrorCompile <= 0 ? 100 : FilesWithErrorCompile / CompiledFilesSuccessful * 100;
            }
        }
    }
}
