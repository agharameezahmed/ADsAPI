using ADsAPI.Models;
using ADsAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ADsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdsController : ControllerBase
    {
        private readonly IAdsRepository _adsRepository;
        public AdsController(IAdsRepository adsRepository)
        {
            _adsRepository = adsRepository;
        }
        /// <summary>
        /// selecting a specific ad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetAd/{id}")]
        public async Task<Ad> Get(int id)
        {
            return await _adsRepository.Get(id);
        }
        /// <summary>
        /// selecting all ads of a specific campaign
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetAdByCampaign/{id}")]
        public async Task<IEnumerable<Ad>> GetAllAdByCampaignId(int id)
        {
            return await _adsRepository.GetAllAdByCampaignId(id);
        }
        /// <summary>
        /// selecting all ads of a specific advertiser
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetAdByAdvertiser/{id}")]
        public async Task<IEnumerable<Ad>> GetAllAdByAdvertiserId(int id)
        {
            return await _adsRepository.GetAllAdByAdvertiserId(id);
        }
        /// <summary>
        /// creating an ad
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Ad>> Create([FromBody] Ad ad)
        {
            var newAd = await _adsRepository.Create(ad);
            return CreatedAtAction(nameof(Get), new { id = newAd.Id });
        }
        /// <summary>
        /// modifying a specific ad
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ad"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult<Ad>> Update(int id , [FromBody] Ad ad)
        {
            if (id != ad.Id)
            {
                return BadRequest();
            }
            await _adsRepository.Update(id , ad);
            return NoContent();
        }
    }
}
