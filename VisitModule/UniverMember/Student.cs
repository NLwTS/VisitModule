using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitModele.MemberUniversity
{
    public class Student : UniversityMember
    {
        private decimal _scholarship;// Стипендия студента
        private int _year; // Срок обучения
        private string _studentId;// Номер студенческого билета
        private string _statusScholarship; //Наличие отсутсвие стипендии
        private int _group; // Группа студента
        private string _fofEducation; // Форма обучения
        private DateTime _entrance; //Дата поступления
        private DateTime _dasEnde; //Дата окончания
        private string _specialSituation; // Особый статус: Многодетность, инвалидность и тд
        private string _participationAdditionalPrograms; // Участие в дополнительных программа: Программы обмена, научные кружки, студенческие проекты или другие активности.

        public decimal Scholarship
        {
            get => _scholarship;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Стипендия не может быть отрицательной");
                }
                _scholarship = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < 1 || value > 6) //Бакалавр или магистр
                {
                    throw new ArgumentException("Некорректный курс");
                }
                _year = value;
            }
        }

        public int Group
        {
            get => _group;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Группа не может быть отрицательной");
                }
                _group = value;
            }
        }

        public string StudentId
        {
            get => _studentId;
            set => _studentId = value;
        }

        public string FofEducation
        {
            get => _fofEducation;
            set => _fofEducation = value;
        }

        public string StatusScholarship
        {
            get => _statusScholarship;
            set
            {
                if (!(value.Contains("Да")||value.Contains("Нет")))
                {
                    throw new ArgumentException("Неверные сведения о наличие стипендии у студента");
                }
                _statusScholarship = value;
            }
        }

        public DateTime Entrance
        {
            get => _entrance;
            set => _entrance = value;
        }

        public DateTime DasEnde
        {
            get => _dasEnde;
            set => _dasEnde = value;
        }

        public string SpecialSituation
        {
            get => _specialSituation;
            set => _specialSituation = value;
        }

        public string ParticipationAdditionalPrograms
        {
            get => _participationAdditionalPrograms;
            set => _participationAdditionalPrograms = value;
        }

        public Student(string name, string surname, string lastname, DateTime entrance, DateTime dasEnde, string faculty, string department,
            string specialization, string fofEducation, string email, string phone, string academicStatus, string gender, string birthday,
            string city, string country, string prefecture, string statusScholarship, decimal scholarship, int year, int group, string studentId, 
            string specialSituation, string participationAdditionalPrograms)
            : base(name, surname, lastname, faculty, department, specialization, email, phone, academicStatus, gender,
                   birthday, city, country, prefecture)
        {
            Entrance = entrance;
            DasEnde = dasEnde;
            FofEducation = fofEducation;
            StatusScholarship = statusScholarship;
            Scholarship = scholarship;
            Year = year;
            Group = group;
            StudentId = studentId;
            SpecialSituation = specialSituation;
            ParticipationAdditionalPrograms = participationAdditionalPrograms;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"ФИО: {Name} {Surname} {Lastname}");
            Console.WriteLine($"Год поступления: {Entrance.ToString("dd.MM.yyyy")}, Год окончания: {DasEnde.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Факультет: {Faculty}, Кафедра: {Department}, Специальность: {Specialization}");
            Console.WriteLine($"Форма обучения: {FofEducation}");
            Console.WriteLine($"Email: {Email}, Телефон: {Phone}");
            Console.WriteLine($"Статус: {AcademicStatus}, Пол: {Gender}, Дата рождения: {BirthDay}");
            Console.WriteLine($"Город: {City}, Страна: {Country}, Регион: {Prefecture}");
            Console.WriteLine($"Наличие стипендии: {StatusScholarship}, Стипендия: {Scholarship} руб.");
            Console.WriteLine($"Курс: {Year}, Группа: {Group}");
            Console.WriteLine($"Номер студенческого: {StudentId}");
            Console.WriteLine($"Льготы: {SpecialSituation}");
            Console.WriteLine($"Участие в дополнительных программах: {ParticipationAdditionalPrograms}");
        }
    }
}
