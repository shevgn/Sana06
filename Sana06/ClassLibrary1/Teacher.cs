namespace ClassLibrary1;


public class Teacher : Human
{
    private string _position;
    private string _department;
    private string _institution;

    public Teacher()
    {
        
    }
    
    public Teacher(string firstName, string lastName, DateTime birthDate, string position, string department, string institution)
        : base(firstName, lastName, birthDate)
    {
        _position = position;
        _department = department;
        _institution = institution;
    }
    
    public Teacher(Human human, string position, string department, string institution)
        : base(human.FirstName, human.LastName, human.BirthDate)
    {
        _position = position;
        _department = department;
        _institution = institution;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.Write($"{_position} {_department} {_institution} ");
    }
}