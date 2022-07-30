
namespace CreeperBazarCosmosRepository
{
	using CreeperBazarEntity;
	using Microsoft.Azure.Cosmos;
	using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddItemAsync(CoveragePremium item)
        {
            await this._container.CreateItemAsync<CoveragePremium>(item, new PartitionKey(item.Id));
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<CoveragePremium>(id, new PartitionKey(id));
        }

        public async Task<CoveragePremium> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<CoveragePremium> response = await this._container.ReadItemAsync<CoveragePremium>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task<IEnumerable<CoveragePremium>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<CoveragePremium>(new QueryDefinition(queryString));
            var results = new List<CoveragePremium>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateItemAsync(string id, CoveragePremium item)
        {
            await this._container.UpsertItemAsync<CoveragePremium>(item, new PartitionKey(id));
        }
    }
}