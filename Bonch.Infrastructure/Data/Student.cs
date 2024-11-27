using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitModule.API.UniversityMember
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
                if (!(value.Contains("Да") || value.Contains("Нет")))
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

        public Student() { }
       
    }
}
