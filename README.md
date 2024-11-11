# Описание классов и их использование

## University Member Class

`UniversityMember` - это класс на C#, предназначенный для представления информации о члене университета (преподаватель или студент). Класс включает такие данные, как личная информация, факультет, академический статус, контактные данные и место проживания.

## Класс: `UniversityMember`

### Свойства

Класс `UniversityMember` содержит следующие свойства:

- **Name** (string): Имя человека.
- **Surname** (string): Фамилия человека.
- **Lastname** (string): Отчество человека.
- **Faculty** (string): Факультет, к которому относится член университета.
- **Department** (string): Кафедра, к которой относится член университета.
- **Specialization** (string): Направление или специальность человека.
- **Email** (string): Адрес электронной почты. Проверяется на корректность при установке (должен содержать `@`).
- **Phone** (string): Номер телефона.
- **AcademicStatus** (string): Академический статус (например, студент, преподаватель).
- **Gender** (string): Пол.
- **BirthDay** (string): Дата рождения.
- **City** (string): Город проживания.
- **Country** (string): Страна проживания.
- **Prefecture** (string): Префектура проживания.

### Конструктор

Конструктор `UniversityMember` принимает параметры для инициализации всех свойств экземпляра класса:

```csharp
public UniversityMember(
    string name,
    string surname,
    string lastname,
    string faculty,
    string department,
    string specialization,
    string email,
    string phone,
    string academicStatus,
    string gender,
    string birthday,
    string city,
    string country,
    string prefecture
)
```

### Пример использования
```csharp
using VisitModele.MemberUniversity;

class Program
{
    static void Main()
    {
        UniversityMember member = new UniversityMember(
            "Иван",
            "Иванов",
            "Иванович",
            "Факультет физики",
            "Кафедра теоретической физики",
            "Физика",
            "ivan.ivanov@example.com",
            "+1234567890",
            "Студент",
            "Мужской",
            "01.01.2000",
            "Москва",
            "Россия",
            "Центральный округ"
        );

        Console.WriteLine($"Имя: {member.Name}");
        Console.WriteLine($"Фамилия: {member.Surname}");
        Console.WriteLine($"Эл.почта: {member.Email}");
    }
}
```


### Исключения
- При попытке установить некорректный Email (без символа @) будет выброшено исключение **ArgumentException**.
