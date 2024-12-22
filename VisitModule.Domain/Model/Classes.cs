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
    }

    public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
}

public class Class
{
    public int Id { get; set; }
    public string ClassName { get; set; } = string.Empty;
}
}
