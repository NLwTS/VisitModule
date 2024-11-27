namespace VisitModule.API.UniversityMember
{
    public class AttendanceRecord
    {
        public int Id { get; set; } // Уникальный идентификатор записи
        public int StudentId { get; set; } // ID студента
        public int DisciplineId { get; set; } // ID дисциплины
        public DateTime AttendanceDate { get; set; } // Дата занятия
        public bool IsPresent { get; set; } // Присутствие на занятии
        public string? Reason { get; set; } // Дополнительные заметки (например, причина отсутствия)
    }
}
