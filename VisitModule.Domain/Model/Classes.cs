using System.ComponentModel.DataAnnotations;

namespace VisitModule.Domain.Model
{
    public class Visit
    {
        public int Id { get; set; }                      // Уникальный идентификатор

        public string Location { get; set; }             // Локация визита
        public DateTime VisitDate { get; set; }          // Дата визита

        public TimeOnly VisitTime { get; set; }

        public string Type { get; set; }

        // Связь с студентом
        public int StudentId { get; set; }
        public Student Student { get; set; }             // Навигационное свойство
    }

    public class Student
    {
        public required int StudentListId { get; set; }

        [Range(0, int.MaxValue)]
        public int scholarship { get; set; }
         
        [Range(1, 6)]
        public int year { get; set; }

        [Range(0, int.MaxValue)]
        public int group { get; set; }

        

        [Required]
        public string StudentFirstName { get ; set; }
        [Required]
        public string StudentSecondName { get; set; }
        [Required]
        public string StudentPatronymic { get; set; }
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

}
