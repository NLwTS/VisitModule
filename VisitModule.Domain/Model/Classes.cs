namespace VisitModule.Domain.Model
{
    public class Visit
    {
        public int Id { get; set; }                      // Уникальный идентификатор
        public string VisitorName { get; set; }          // Имя посетителя
        public string Purpose { get; set; }              // Цель визита
        public string Location { get; set; }             // Локация визита
        public DateTime VisitDate { get; set; }          // Дата визита
        public TimeSpan Duration { get; set; }           // Продолжительность визита

        // Связь с классом
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }         // Навигационное свойство

        // Связь с студентом
        public int StudentId { get; set; }
        public Student Student { get; set; }             // Навигационное свойство
    }

    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;

        // Коллекция визитов, связанных с студентом
        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }

    public class Classroom
    {
        public int Id { get; set; }
        public string ClassName { get; set; } = string.Empty;

        // Коллекция визитов, связанных с классом
        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}
