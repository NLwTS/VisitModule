namespace VisitModule.Domain.Models

{
    public class Visit
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int ClassId { get; set; }
    public DateTime VisitDate { get; set; }
    public bool IsPresent { get; set; }
}

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
}

public class Class
{
    public int Id { get; set; }
    public string ClassName { get; set; } = string.Empty;
}
}
