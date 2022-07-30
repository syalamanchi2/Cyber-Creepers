using CreeperBazarBusinessLogic;
using CreeperBazarEntity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CreeperBazarAPI.Controllers
{
	public class CreeperController : Controller
	{
		private readonly ICreeperBazarMultiInsurence creeperBazarMultiInsurence;

        private readonly ILogger<CreeperController> logger;

        public CreeperController(ICreeperBazarMultiInsurence creeperBazarMultiInsurence)
		{
			this.creeperBazarMultiInsurence = creeperBazarMultiInsurence;
		}

        [HttpGet]
        public async Task<IEnumerable<CoveragePremium>> GetHealthCoverages(string lob)
        {
            try
            {
               var response = await this.creeperBazarMultiInsurence.GetHealthCoverages(lob);
                return response;
            }
            catch (Exception e)
            {
                this.logger.LogError(e.ToString());
                return Enumerable.Empty<CoveragePremium>();
            }
        }
    }
}
