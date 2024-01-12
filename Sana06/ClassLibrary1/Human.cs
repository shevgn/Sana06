namespace ClassLibrary1;

public class Human
{
    private string _firstName;
    private string _lastName;
    private DateTime _birthDate;

    public Human()
    {
        
    }

    public Human(string firstName, string lastName, DateTime birthDate)
    {
        _firstName = firstName;
        _lastName = lastName;
        _birthDate = birthDate;
    }
    
    public virtual string ShowInfo()
    {
        return $"{_firstName} {_lastName} {_birthDate.ToShortDateString()} ";
    }
    
    public string FirstName => _firstName;
    public string LastName => _lastName;
    public DateTime BirthDate => _birthDate;
}