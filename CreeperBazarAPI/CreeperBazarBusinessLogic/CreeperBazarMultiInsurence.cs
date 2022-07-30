using CreeperBazarCosmosRepository;
using CreeperBazarEntity;

namespace CreeperBazarBusinessLogic
{
	public class CreeperBazarMultiInsurence : ICreeperBazarMultiInsurence
	{
		private readonly ICosmosDbService cosmosService;

		public CreeperBazarMultiInsurence(ICosmosDbService cosmosService)
		{
			this.cosmosService = cosmosService;
		}

		public async Task<IEnumerable<CoveragePremium>> GetHealthCoverages(string lob)
		{
			var data = await cosmosService.GetItemsAsync(lob);
			return data;
		}

		public async void UpdateCoverage(List<CoveragePremium> coveragePremium)
		{
			foreach (var item in coveragePremium)
			{
				await cosmosService.UpdateItemAsync(item.Id, item);
			}
		}
	}
}