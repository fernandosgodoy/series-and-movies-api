using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesCollection.BusinessApp.Dtos.Movies;
using MoviesCollection.BusinessApp.Maintenance;
using System.Threading.Tasks;

namespace MoviesCollection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController 
        : ControllerBase
    {
        private readonly MovieMaintenanceService movieMaintenanceService;

        public MovieController(MovieMaintenanceService MovieMaintService)
        {
            this.movieMaintenanceService = MovieMaintService;
        }

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            return Ok(await this.movieMaintenanceService.ListAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var Movie = await this.movieMaintenanceService.GetByIdAsync(id);

            if (Movie == null)
                return NoContent();

            return Ok(Movie);

        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] MovieDto MovieDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await this.movieMaintenanceService.InsertAsync(MovieDto);
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
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] MovieDto MovieDto)
        {
            try
            {
                if (ModelState.IsValid)
                { 
                    var result = await this.movieMaintenanceService.UpdateAsync(id, MovieDto);
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
                var result = await this.movieMaintenanceService.DeleteAsync(id);
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
