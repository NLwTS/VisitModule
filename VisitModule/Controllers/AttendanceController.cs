using Microsoft.AspNetCore.Mvc;
using VisitModule.API.Services;
using VisitModule.API.UniversityMember;

namespace VisitModule.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceRepository _repository;

        public AttendanceController(AttendanceRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Получить записи о посещении студента по ID.
        /// </summary>
        /// <param name="studentId">ID студента</param>
        /// <returns>Список записей о посещении</returns>
        [HttpGet("{studentId}")]
        public async Task<IActionResult> GetAttendance(int studentId)
        {
            var records = await _repository.GetAttendanceByStudentAsync(studentId);
            return Ok(records);
        }

        /// <summary>
        /// Добавить новую запись о посещении.
        /// </summary>
        /// <param name="record">Модель записи</param>
        [HttpPost]
        public async Task<IActionResult> AddAttendance([FromBody] AttendanceRecord record)
        {
            await _repository.AddAttendanceAsync(record);
            return Ok();
        }
    }



}
