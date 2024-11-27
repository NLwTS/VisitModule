using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitModele.MemberUniversity
{
    

    public class UniversityMember
    {
        //ФИО человека
        private string _name;//
        private string _surname;//
        private string _lastname;//

        //Факультет и кафедра
        private string _faculty;//
        private string _department;//

        // Направление или специальность
        private string _specialization;//

        //Контакты
        private string _email;//
        private string _phone;//

        //Преподаватель или студент
        private string _academicStatus;//

        private string _gender;//

        private string _birthday;//

        private string _city;//

        private string _country;//

        private string _prefecture;//

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }

        public string Faculty
        {
            get => _faculty;
            set => _faculty = value;
        }

        public string Department
        {
            get => _department;
            set => _department = value;
        }

        public string Specialization
        {
            get => _specialization;
            set => _specialization = value;
        }

        public string Email
        {
            get => _email;
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Некорректный email");
                }
                _email = value;
            }
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public string AcademicStatus
        {
            get => _academicStatus;
            set => _academicStatus = value;
        }

        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public string BirthDay
        {
            get => _birthday;
            set => _birthday = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string Prefecture
        {
            get => _prefecture;
            set => _prefecture = value;
        }

        public UniversityMember(string name, string surname, string lastname, string faculty, string department,
            string specialization, string email, string phone, string academicStatus, string gender, string birthday,
            string city, string country, string prefecture)
        {
            Name = name;
            Surname = surname;
            Lastname = lastname;
            Faculty = faculty;
            Department = department;
            Specialization = specialization;
            Email = email;
            Phone = phone;
            AcademicStatus = academicStatus;
            Gender = gender;
            BirthDay = birthday;
            City = city;
            Country = country;
            Prefecture = prefecture;
        }

        /*
        public void displayInfo()
        {
            Console.WriteLine("Фамилия " + Surname);
            Console.WriteLine("Имя " + Name);
            Console.WriteLine("Отчество " + Lastname);
            Console.WriteLine("Факультет " + Faculty);
            Console.WriteLine("Кафедра " + Department);
            Console.WriteLine("Направление " + Specialization);
            Console.WriteLine("Почта " + Email);
            Console.WriteLine("Номер телефона " + Phone);
            Console.WriteLine("Академический статус " + AcademicStatus);
            Console.WriteLine("Пол " + Gender);
            Console.WriteLine("Дата рождения " + BirthDay);
            Console.WriteLine("Город " + City);
            Console.WriteLine("Страна " + Country);
            Console.WriteLine("Префектура " + Prefecture);
        }*/
    }
}
