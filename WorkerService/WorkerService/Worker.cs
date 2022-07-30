using WorkerServiceProvider;

namespace WorkerService
{
	public class TimedHostedService : IHostedService, IDisposable
	{
        private int executionCount = 0;
        private readonly ILogger<TimedHostedService> _logger;
        private Timer? _timer = null;
        private readonly WorkerServiceProvider.IServiceProvider serviceProvider;

        public TimedHostedService(ILogger<TimedHostedService> logger, WorkerServiceProvider.IServiceProvider serviceProvider)
		{
			_logger = logger;
			this.serviceProvider = serviceProvider;
		}

		public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromDays(1));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var count = Interlocked.Increment(ref executionCount);
            var data = MockData.GetMockData();
            serviceProvider.SaveCoveragePremium(data);
            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}