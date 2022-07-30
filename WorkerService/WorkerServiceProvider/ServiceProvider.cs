using Entities;

namespace WorkerServiceProvider
{
	public class ServiceProvider : IServiceProvider
	{
		private readonly IServiceConnector serviceConnector;

		public ServiceProvider(IServiceConnector serviceConnector)
		{
			this.serviceConnector = serviceConnector;

		}
		public async Task SaveCoveragePremium(List<CoveragePremium> coveragePremium)
		{
		 await serviceConnector.SaveCoveragePremium(coveragePremium);
		}
	
	}
}