using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesCollection.BusinessApp.Dtos.Episodes;
using MoviesCollection.BusinessApp.Maintenance;
using System.Threading.Tasks;

namespace EpisodesCollection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly EpisodeMaintenanceService episodeMaintenanceService;

        public EpisodeController(EpisodeMaintenanceService episodeMaintService)
        {
            this.episodeMaintenanceService = episodeMaintService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            return Ok(await this.episodeMaintenanceService.ListAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var Episode = await this.episodeMaintenanceService.GetByIdAsync(id);

            if (Episode == null)
                return NoContent();

            return Ok(Episode);

        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] EpisodeDto EpisodeDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await this.episodeMaintenanceService.InsertAsync(EpisodeDto);
                    if (result.Success)
                        return Ok(result);
                    else
                        return BadRequest(result);
                }
                else
                    return BadRequest();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] EpisodeDto EpisodeDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await this.episodeMaintenanceService.UpdateAsync(id, EpisodeDto);
                    if (result.Success)
                        return Ok(result);
                    else
                        return BadRequest(result);
                }
                else
                    return BadRequest();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            try
            {
                var result = await this.episodeMaintenanceService.DeleteAsync(id);
                if (result.Success)
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
