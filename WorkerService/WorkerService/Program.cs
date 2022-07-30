using WorkerService;
using WorkerServiceProvider;

IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices(services =>
	{
		services.AddTransient<IServiceConnector, ServiceConnector>();
		services.AddTransient<WorkerServiceProvider.IServiceProvider, WorkerServiceProvider.ServiceProvider>();
		services.AddHostedService<TimedHostedService>();
	})
	.Build();

await host.RunAsync();
