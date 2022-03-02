using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesCollection.BusinessApp.Dtos.Actors;
using MoviesCollection.BusinessApp.Maintenance;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesCollection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly ActorMaintenanceService actorMaintenanceService;

        public ActorController(ActorMaintenanceService actorMaintService)
        {
            this.actorMaintenanceService = actorMaintService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            return Ok(await this.actorMaintenanceService.ListAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var actor = await this.actorMaintenanceService.GetByIdAsync(id);

            if (actor == null)
                return NoContent();

            return Ok(actor);
            
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody]ActorDto actorDto)
        {
            try
            {
                var result = await this.actorMaintenanceService.InsertAsync(actorDto);
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

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAsync([FromRoute]int id, [FromBody] ActorDto actorDto)
        {
            try
            {
                var result = await this.actorMaintenanceService.UpdateAsync(id, actorDto);
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

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            try
            {
                var result = await this.actorMaintenanceService.DeleteAsync(id);
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
