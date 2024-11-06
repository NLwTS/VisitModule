
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

            // Демонстрация работы базового класса
            /*
            UniversityMember member1 = new UniversityMember(
             "Иван", "Иванов", "Иванович",
             "Факультет компьютерных наук", "Кафедра программирования",
             "Программирование", "ivan.ivanov@example.com",
             "+79000000000", "Студент", "Мужской",
             "01.01.2000", "Москва", "Россия", "Центральный"
         );

            UniversityMember member2 = new UniversityMember(
                "Мария", "Петрова", "Сергеевна",
                "Факультет математики", "Кафедра прикладной математики",
                "Прикладная математика", "maria.petrova@example.com",
                "+79000000001", "Студент", "Женский",
                "02.02.1999", "Санкт-Петербург", "Россия", "Северо-Западный"
            );

            UniversityMember member3 = new UniversityMember(
                "Алексей", "Сидоров", "Александрович",
                "Факультет физики", "Кафедра теоретической физики",
                "Теоретическая физика", "aleksey.sidorov@example.com",
                "+79000000002", "Преподаватель", "Мужской",
                "03.03.1985", "Екатеринбург", "Россия", "Уральский"
            );

            // Выводим информацию о каждом участнике
            member1.displayInfo();
            Console.WriteLine(); // Печатаем пустую строку для разделения
            member2.displayInfo();
            Console.WriteLine();
            member3.displayInfo();
            */
        }
    }
}
