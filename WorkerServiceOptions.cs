namespace CodeCompilerSettingsModels
{
    public class WorkerServiceOptions
    {
        public int Interval { get; set; }
        public int MaxThreads { get; set; }
        public int InternalBufferSize { get; set; }
        public bool SendMessagesToManager { get; set; }
        public int SendMessagesPort { get; set; }
    }
}