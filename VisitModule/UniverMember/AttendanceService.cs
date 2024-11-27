namespace VisitModule.API.UniverMember
{
    public class AttendanceService
    {
        private readonly List<AttendanceRecord> _attendanceRecords = new();

        // Добавление записи
        public void AddAttendance(AttendanceRecord record)
        {
            _attendanceRecords.Add(record);
        }

        // Получение посещаемости студента по ID
        public List<AttendanceRecord> GetAttendanceByStudent(int studentId)
        {
            return _attendanceRecords.Where(r => r.StudentId == studentId).ToList();
        }

        // Получение списка студентов, отсутствовавших на занятии
        public List<AttendanceRecord> GetAbsenteesByDate(DateTime date)
        {
            return _attendanceRecords.Where(r => r.AttendanceDate.Date == date.Date && !r.IsPresent).ToList();
        }

        // Удаление записи
        public void RemoveAttendance(int recordId)
        {
            var record = _attendanceRecords.FirstOrDefault(r => r.Id == recordId);
            if (record != null)
                _attendanceRecords.Remove(record);
        }
    }
}
