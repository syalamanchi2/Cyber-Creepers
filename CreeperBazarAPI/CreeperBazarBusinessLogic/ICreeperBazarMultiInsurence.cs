using CreeperBazarEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreeperBazarBusinessLogic
{
	public interface ICreeperBazarMultiInsurence	
	{
		Task<IEnumerable<CoveragePremium>> GetHealthCoverages(string lob);
		void UpdateCoverage(List<CoveragePremium> coveragePremium);
	}
}
