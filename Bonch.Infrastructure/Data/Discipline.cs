using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VisitModule.API.UniversityMember
{
    public class QuantityHours
    {
        private int _lecture;
        private int _practical;
        private int _independentwork;
        public int Lecture
        {
            get => _lecture;
            set => _lecture = value;
        }
        public int Practical
        {
            get => _practical;
            set => _practical = value;
        }
        public int Independentwork
        {
            get => _independentwork;
            set => _independentwork = value;
        }
        public QuantityHours(int lecture, int practical, int independentWork)
        {
            Lecture = lecture;
            Practical = practical;
            Independentwork = independentWork;
        }
        public override string ToString()
        {
            return $"Лекций {Lecture} часов; Практических занятий {Practical} часов; Самостоятельных работ" +
                $" {Independentwork} часов; Всего часов дисциплины {Lecture + Practical + Independentwork}";
        }
        public QuantityHours() { }
    }

    public class Discipline
    {
        private string _nameDisc;
        private string _description;
        private string _codeDisc;
        private List<string> _purpose; //Цели дисциплины
        private List<string> _tasks; //Задачи дисциплины
        private List<QuantityHours> _quantityHours; //Количество часов 
        private string _formOfStudy; //Форма обучения
        private List<string> _assessmentMethods; //Способы проверки знаний
        private List<string> _literature;
        private List<string> _professors;
        public string NameDisc
        {
            get => _nameDisc;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Название предмета не может быть пустым или состоять только из пробелов.");
                }
                _nameDisc = value;
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Описание предмета не может быть пустым или состоять только из пробелов.");
                }
                _description = value;
            }
        }
        public string CodeDisc
        {
            get => _codeDisc;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Код предмета не может быть пустым или состоять только из пробелов.");
                }
                _codeDisc = value;
            }
        }
        public List<string> Purpose
        {
            get => _purpose;
            set => _purpose = value ?? new List<string>();
        }
        public List<string> Tasks
        {
            get => _tasks;
            set => _tasks = value ?? new List<string>();
        }
        public List<QuantityHours> QuantityHours
        {
            get => _quantityHours;
            set => _quantityHours = value ?? new List<QuantityHours>();
        }
        public string FormOfStudy
        {
            get => _formOfStudy;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Форма обучения не может быть пустым или состоять только из пробелов.");
                }
                _formOfStudy = value;
            }
        }
        public List<string> AssessmentMethods
        {
            get => _assessmentMethods;
            set => _assessmentMethods = value ?? new List<string>();
        }
        public List<string> Literature
        {
            get => _literature;
            set => _literature = value ?? new List<string>();
        }
        public List<string> Professors
        {
            get => _professors;
            set => _professors = value ?? new List<string>();
        }
        public Discipline() { } // Конструктор по умолчанию для EF


    }
}