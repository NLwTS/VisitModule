using Microsoft.AspNetCore.Mvc;
using VisitModule.API.UniverMember;

namespace VisitModule.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceService _service;

        public AttendanceController(AttendanceService service)
        {
            _service = service;
        }

        [HttpGet("{studentId}")]
        public IActionResult GetAttendance(int studentId)
        {
            var attendance = _service.GetAttendanceByStudent(studentId);
            return Ok(attendance);
        }

        [HttpPost]
        public IActionResult AddAttendance([FromBody] AttendanceRecord record)
        {
            _service.AddAttendance(record);
            return Ok();
        }
    }

}
