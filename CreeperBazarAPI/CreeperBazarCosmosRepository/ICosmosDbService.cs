namespace CreeperBazarCosmosRepository
{
	using CreeperBazarEntity;
	using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICosmosDbService
    {
        Task<IEnumerable<CoveragePremium>> GetItemsAsync(string query);
        Task<CoveragePremium> GetItemAsync(string id);
        Task AddItemAsync(CoveragePremium item);
        Task UpdateItemAsync(string id, CoveragePremium item);
        Task DeleteItemAsync(string id);
    }
}