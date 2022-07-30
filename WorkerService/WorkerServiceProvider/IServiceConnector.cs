using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceProvider
{
	public interface IServiceConnector
	{
		Task SaveCoveragePremium(List<CoveragePremium> coveragePremium);
	}
}
