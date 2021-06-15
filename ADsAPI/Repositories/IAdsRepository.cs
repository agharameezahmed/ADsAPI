using ADsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ADsAPI.Repositories
{
    public interface IAdsRepository
    {
        Task<Ad> Get(int id);
        Task<IEnumerable<Ad>> GetAllAdByCampaignId(int id);
        Task<IEnumerable<Ad>> GetAllAdByAdvertiserId(int id);
        Task<Ad> Create(Ad model);
        Task<Ad> Update(int id , Ad model);

    }
}
