using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitModele.MemberUniversity
{
    public class ScheduleEntry
    {
        private string _discipline; //Название дисциплины
        private string _daysofWeek; //День недели
        private string _time; //Время проведения занятия
        private string _room; //Аудитория

        public string Discipline
        {
            get => _discipline;
            set => _discipline = value;
        }

        public string DaysofWeek
        {
            get => _daysofWeek;
            set => _daysofWeek = value;
        }

        public string Time
        {
            get => _time; 
            set => _time = value;
        }

        public string Room
        {
            get => _room;
            set => _room = value;
        }

        public ScheduleEntry(string discipline, string dayOfWeek, string time, string room)
        {
            Discipline = discipline;
            DaysofWeek = dayOfWeek;
            Time = time;
            Room = room;
        }

        public override string ToString()
        {
            return $"{Discipline} - {DaysofWeek} в {Time}, аудитория: {Room}";
        }
    }

    public class Professor : UniversityMember
    {
        private string _position; //Должность
        private string _degree; //Ученая степень
        private string _academicTitle; // Ученое звание
        private int _experienceYears; // Стаж работы
        private DateTime _dateOfEmployment; // Дата начала преподавания в университете
        private List<string> _disciplines; // Список дисциплин, которые преподает преподаватель
        private List<ScheduleEntry> _schedule; // Расписание преподавателя
        private string _officeHours; // Часы приёма преподавателя

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public string Degree
        {
            get => _degree;
            set => _degree = value;
        }

        public string AcademicTitle
        {
            get => _academicTitle;
            set => _academicTitle = value;
        }

        public int ExperienceYears
        {
            get => _experienceYears;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Стаж не может быть отрицательным");
                }
                _experienceYears = value;
            }
        }

        public DateTime DateOfEmployment
        {
            get => _dateOfEmployment;
            set => _dateOfEmployment = value;
        }

        public List<string> Disciplines
        {
            get => _disciplines;
            set => _disciplines = value ?? new List<string>();
        }

        public List<ScheduleEntry> Schedule
        {
            get => _schedule;
            set => _schedule = value ?? new List<ScheduleEntry>();
        }

        public string OfficeHours
        {
            get => _officeHours;
            set => _officeHours = value;
        }

        public Professor(string name, string surname, string lastname, string faculty, string department,
                      string specialization, string email, string phone, string academicStatus, string gender,
                      string birthday, string city, string country, string prefecture,
                      string position, string degree, string academicTitle, int experienceYears,
                      DateTime dateOfEmployment, List<string> disciplines, List<ScheduleEntry> schedule,
                      string officeHours)
           : base(name, surname, lastname, faculty, department, specialization, email, phone, academicStatus,
                  gender, birthday, city, country, prefecture)
        {
            Position = position;
            Degree = degree;
            AcademicTitle = academicTitle;
            ExperienceYears = experienceYears;
            DateOfEmployment = dateOfEmployment;
            Disciplines = disciplines ?? new List<string>();
            Schedule = schedule ?? new List<ScheduleEntry>();
            OfficeHours = officeHours;
        }

        public void DisplayProfessorInfo()
        {
            Console.WriteLine($"ФИО: {Name} {Surname} {Lastname}");
            Console.WriteLine($"Пол: {Gender}");
            Console.WriteLine($"Дата рождение {BirthDay}");
            Console.WriteLine($"Факультет: {Faculty}, Кафедра: {Department}, Специальность: {Specialization}");
            Console.WriteLine($"Email: {Email}, Телефон: {Phone}");
            Console.WriteLine($"Академический статус: {AcademicStatus}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Ученая степень: {Degree}");
            Console.WriteLine($"Ученое звание: {AcademicTitle}");
            Console.WriteLine($"Стаж работы (лет): {ExperienceYears}");
            Console.WriteLine($"Дата прихода на работу: {DateOfEmployment.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Город: {City}, Страна: {Country}, Регион: {Prefecture}");
            Console.WriteLine($"Дисциплины: {(Disciplines.Count > 0 ? string.Join(", ", Disciplines) : "Нет данных")}");
            Console.WriteLine($"Расписание: ");
            if (Schedule.Count > 0)
            {
                foreach (var entry in Schedule)
                {
                    Console.WriteLine($" -  {entry}");
                }
            }
            else
            {
                Console.WriteLine($"Нет данных о расписании");
            }
            Console.WriteLine($"Часы приёма: {(string.IsNullOrEmpty(OfficeHours) ? "Нет данных" : OfficeHours)}");
        }
    }
}
