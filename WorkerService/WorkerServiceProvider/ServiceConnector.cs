using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceProvider
{
    public class ServiceConnector : IServiceConnector
    {
        public HttpClient HttpClientInstance
        {
            get
            {
                return new HttpClient();
            }
        }
        public async Task SaveCoveragePremium(List<CoveragePremium> coveragePremium)
        {
          await this.HttpClientInstance.PostAsJsonAsync("http://localhost:8200", coveragePremium);
        }
    }
}
