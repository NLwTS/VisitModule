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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVisit(int id)
        {
            var visit = await _visitRepository.GetVisitByIdAsync(id);
            if (visit == null)
            {
                return NotFound();
            }
            return Ok(visit);
        }

        [HttpPost]
        public async Task<IActionResult> AddVisit([FromBody] Visit visit)
        {
            await _visitRepository.AddVisitAsync(visit);
            await _visitRepository.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVisit), new { id = visit.Id }, visit);
        }
    }
}