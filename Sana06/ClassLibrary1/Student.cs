namespace ClassLibrary1;


public class Student : Human
{
    private int _course;
    private string _group;
    private string _faculty;
    private string _institution;

    public Student()
    {
        
    }
    
    public Student(string firstName, string lastName, DateTime birthDate, int course, string group, string faculty, string institution)
        : base(firstName, lastName, birthDate)
    {
        _course = course;
        _group = group;
        _faculty = faculty;
        _institution = institution;
    }
    
    public Student(Human human, int course, string group, string faculty, string institution)
        : base(human.FirstName, human.LastName, human.BirthDate)
    {
        _course = course;
        _group = group;
        _faculty = faculty;
        _institution = institution;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.Write($"{_course} {_group} {_faculty} {_institution} ");
    }
}