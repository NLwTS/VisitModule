using System.ComponentModel.DataAnnotations;

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
        public int id { get; set; }

        [Range(0, double.MaxValue)]
        public decimal scholarship { get; set; }

        [Range(1, 6)]
        public int year { get; set; }

        [Range(0, int.MaxValue)]
        public int group { get; set; }

        [Required]
        public string studentid { get; set; }

        [Required]
        public string StudentFirstName { get; set; }
        [Required]
        public string StudentSecondName { get; set; }
        [Required]
        public string fofeducation { get; set; }

        [Required]
        public string statusscholarship { get; set; }

        [Required]
        public DateTime entrance { get; set; }

        [Required]
        public DateTime dasende { get; set; }

        public string specialsituation { get; set; }
        public string participationadditionalprograms { get; set; }
    }

    public class Classroom
    {
        public int Id { get; set; }
        public string ClassName { get; set; } = string.Empty;

        // Коллекция визитов, связанных с классом
        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}
