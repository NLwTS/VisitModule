
using VisitModele.AcademicDiscipline;
using VisitModele.MemberUniversity; //Для демонстрации базового класса

namespace VisitModele
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }*/

        public static void Main(string[] args)
        {
            Student std1 = new Student("Иван", "Иванов", "Иванович", new DateTime(2019,7,1), new DateTime(2023, 6, 11), "Физико-математический", "Математика", "Прикладная математика",
                "Очная","ivan.ivanov@example.com", "+79001234567", "Студент", "Мужской", "01.01.2000",
                "Москва", "Россия", "Центральный", "Да", 15000m, 2, 53413, "S123456", "Нет", "Научная конфиренция");

            Student std2 = new Student("Мария", "Смирнова", "Александровна", new DateTime(2018,7,22), new DateTime(2023, 6, 17),"Биологический", "Биохимия", "Медицинская биохимия",
                "Очно-Заочная","maria.smirnova@example.com", "+79007654321", "Студент", "Женский", "15.05.2001",
                "Санкт-Петербург", "Россия", "Северо-Западный", "Да", 20000m, 3, 42135, "S654321", "Многодетная семья", "Учеба в Киото по обмену");

            Student std3 = new Student("Максим", "Петров", "Сергеевич", new DateTime(2020, 7, 13), new DateTime(2024, 6, 22),"Информационные технологии", "Программирование", "Инженерия ПО",
                "Очная", "alexey.petrov@example.com", "+79009876543", "Студент", "Мужской", "10.10.2002",
                "Новосибирск", "Россия", "Сибирский", "Да", 18000m, 1, 32345, "S987654", "Глаукома", "Нет");

            // Вывод информации о студентах
            Console.WriteLine("Информация о студентах:");
            Console.WriteLine();

            std1.DisplayStudentInfo();
            Console.WriteLine("\n----------------------\n");

            std2.DisplayStudentInfo();
            Console.WriteLine("\n----------------------\n");

            std3.DisplayStudentInfo();
            Console.WriteLine("\n----------------------\n");

            //***************************************************************************************
            var schedule1 = new List<ScheduleEntry>
            {
                new ScheduleEntry("Математика", "Понедельник", "10:00", "Аудитория 101"),
                new ScheduleEntry("Физика", "Среда", "14:00", "Аудитория 203")
            };

            var schedule2 = new List<ScheduleEntry>
            {
                new ScheduleEntry("Информатика", "Вторник", "09:00", "Аудитория 305"),
                new ScheduleEntry("Программирование", "Четверг", "12:00", "Аудитория 307")
            };

            var schedule3 = new List<ScheduleEntry>
            {
                new ScheduleEntry("Химия", "Пятница", "11:00", "Аудитория 401"),
                new ScheduleEntry("Биология", "Среда", "15:00", "Аудитория 403")
            };

            Professor professor1 = new Professor(
                "Иван", "Иванов", "Петрович", "Факультет физики", "Кафедра теоретической физики",
                "Физика", "ivanov@example.com", "1234567890", "Преподаватель", "Мужской",
                "01.01.1970", "Москва", "Россия", "Центральный округ",
                "Доцент", "Кандидат наук", "Доцент", 15, DateTime.Parse("2005-09-01"),
                new List<string> { "Математика", "Физика" }, schedule1, "Понедельник и среда с 13:00 до 15:00"
            );

            Professor professor2 = new Professor(
                "Мария", "Сидорова", "Александровна", "Факультет информатики", "Кафедра программирования",
                "Информатика", "sidorova@example.com", "0987654321", "Преподаватель", "Женский",
                "12.05.1980", "Санкт-Петербург", "Россия", "Северный округ",
                "Старший преподаватель", "Доктор наук", "Профессор", 20, DateTime.Parse("2003-09-01"),
                new List<string> { "Информатика", "Программирование" }, schedule2, "Вторник и четверг с 10:00 до 12:00"
            );

            Professor professor3 = new Professor(
                "Алексей", "Николаев", "Сергеевич", "Факультет биологии", "Кафедра биохимии",
                "Биология", "nikolaev@example.com", "1231231234", "Преподаватель", "Мужской",
                "15.09.1975", "Новосибирск", "Россия", "Западный округ",
                "Профессор", "Кандидат наук", "Профессор", 18, DateTime.Parse("2007-09-01"),
                new List<string> { "Химия", "Биология" }, schedule3, "Пятница с 13:00 до 15:00"
            );

            // Демонстрация информации о преподавателях
            Console.WriteLine("Информация о преподавателях:\n");
            Console.WriteLine();

            professor1.DisplayProfessorInfo();
            Console.WriteLine("\n----------------------\n");

            professor2.DisplayProfessorInfo();
            Console.WriteLine("\n----------------------\n");

            professor3.DisplayProfessorInfo();
            Console.WriteLine("\n----------------------\n");

            //***************************************************************************************
            var discipline1 = new Discipline(
                nameDisc: "Математический анализ",
                description: "Изучение основ анализа функций и пределов.",
                codeDisc: "MATH101",
                purpose: new List<string> { "Развитие логического мышления", "Формирование математических навыков" },
                tasks: new List<string> { "Изучить дифференциальные исчисления", "Научиться решать интегралы" },
                quantityHours: new List<QuantityHours>
                {
                    new QuantityHours(lecture: 40, practical: 30, independentWork: 20)
                },
                formOfStudy: "Очная, Очно-Заочная",
                assessmentMethods: new List<string> { "Экзамен", "Тестирование" },
                literature: new List<string> { "Кудрявцев Л.Д. - Математический анализ", "Шарыгин И.Ф. - Основы алгебры и анализа" },
                professors: new List<string> { "Иванов И.И.", "Петров П.П." }
            );

            var discipline2 = new Discipline(
                nameDisc: "Программирование на C#",
                description: "Основы объектно-ориентированного программирования и языка C#.",
                codeDisc: "CSHARP102",
                purpose: new List<string> { "Научиться писать программы", "Изучить концепции ООП" },
                tasks: new List<string> { "Реализовать проекты на C#", "Освоить LINQ и коллекции" },
                quantityHours: new List<QuantityHours>
                {
                    new QuantityHours(lecture: 20, practical: 40, independentWork: 60)
                },
                formOfStudy: "Дистанционная, Очно-Заочная",
                assessmentMethods: new List<string> { "Курсовая работа", "Практические задания" },
                literature: new List<string> { "Троелсен А. - C# и платформа .NET", "Скит Дж. - C# для профессионалов" },
                professors: new List<string> { "Сидоров С.С.", "Кузнецова А.А." }
            );

            var discipline3 = new Discipline(
                nameDisc: "Физика",
                description: "Фундаментальные законы природы и их применение.",
                codeDisc: "PHYS103",
                purpose: new List<string> { "Изучить основные законы физики", "Применять физические законы на практике" },
                tasks: new List<string> { "Решение задач по механике", "Изучение законов термодинамики" },
                quantityHours: new List<QuantityHours>
                {
                    new QuantityHours(lecture: 50, practical: 40, independentWork: 20)
                },
                formOfStudy: "Очная",
                assessmentMethods: new List<string> { "Лабораторные работы", "Устный экзамен" },
                literature: new List<string> { "Савельев И.В. - Курс физики", "Гринев А.Ю. - Физика для инженеров" },
                professors: new List<string> { "Александров А.А.", "Евдокимов Е.Е." }
            );

            // Демонстрация информации о предметах
            var disciplines = new List<Discipline> { discipline1, discipline2, discipline3 };

            Console.WriteLine("Информация о предметах:\n");
            foreach (var discipline in disciplines)
            {
                discipline.DisciplineInfo();
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
