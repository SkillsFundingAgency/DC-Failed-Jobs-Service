using ESFA.DC.Queueing;

namespace ESFA.DC.FailedJob.Service.Configuration
{
    public sealed class JobStatusQueueConfiguration : QueueConfiguration
    {
        public JobStatusQueueConfiguration(string connectionString, string queueName, int maxConcurrentCalls, int minimumBackoffSeconds = 5, int maximumBackoffSeconds = 50, int maximumRetryCount = 10)
            : base(connectionString, queueName, maxConcurrentCalls, minimumBackoffSeconds, maximumBackoffSeconds, maximumRetryCount)
        {
        }
    }
}
