using ADsAPI.Context;
using ADsAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ADsAPI.Repositories
{
    public class AdsRepository : IAdsRepository
    {
        private readonly AdContext _context;
        public AdsRepository(AdContext context)
        {
            _context = context;
        }
        public async Task<Ad> Create(Ad ad)
        {
            // await implementation to create new ad
            return ad;
        }

        public async Task<Ad> Get(int id)
        {
            // await implementaion to fetch record from db context
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ad>> GetAllAdByAdvertiserId(int id)
        {
            // await implementaion to fetch record from db context
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ad>> GetAllAdByCampaignId(int id)
        {
            // await implementaion to fetch record from db context
            throw new NotImplementedException();
        }

        public async Task<Ad> Update(int id, Ad ad)
        {
            // await implementation to update ad
            return ad;
        }
    }
}
