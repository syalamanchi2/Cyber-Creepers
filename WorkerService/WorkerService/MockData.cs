using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService
{
	public static class MockData
	{
		public static List<CoveragePremium> GetMockData()
		{
			var coveragePremium = new List<CoveragePremium>();
			coveragePremium.Add(new CoveragePremium(){ Lob = "Health", Career = "HDFC", CoverageAmount="3L", AnnualPremium="4000"});
			coveragePremium.Add(new CoveragePremium() { Lob = "Health", Career = "ICICI", CoverageAmount = "3L", AnnualPremium = "4500" });
			coveragePremium.Add(new CoveragePremium() { Lob = "Health", Career = "LIC", CoverageAmount = "3L", AnnualPremium = "50000" });
			return coveragePremium;
		}
	}

	
}
