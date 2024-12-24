using Microsoft.AspNetCore.Mvc;
using VisitModule.Domain.Model;
using VisitModule.Infrastructure.Repository;

namespace VisitModule.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitsController : ControllerBase
    {
        private readonly IVisitRepository _visitRepository;

        public VisitsController(IVisitRepository visitRepository)
        {
            _visitRepository = visitRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetVisits()
        {
            var visits = await _visitRepository.GetVisitsAsync();
            return Ok(visits);
        }

        [HttpPost]
        public async Task<IActionResult> AddVisit([FromBody] Visit visit)
        {
            await _visitRepository.AddVisitAsync(visit);
            await _visitRepository.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVisits), new { id = visit.Id }, visit);
        }
    }
}