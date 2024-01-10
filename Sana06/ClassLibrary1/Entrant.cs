namespace ClassLibrary1;

public class Entrant : Human
{
    private float _znoCertificatePoints;
    private float _educationDocumentPoints;
    private string _generalEducationInstitutionName;

    public Entrant()
    {

    }

    public Entrant(string firstName, string lastName, DateTime birthDate, float znoCertificatePoints, float educationDocumentPoints, string generalEducationInstitutionName)
        : base(firstName, lastName, birthDate)
    {
        _znoCertificatePoints = znoCertificatePoints;
        _educationDocumentPoints = educationDocumentPoints;
        _generalEducationInstitutionName = generalEducationInstitutionName;
    }
    
    public Entrant(Human human, float znoCertificatePoints, float educationDocumentPoints, string generalEducationInstitutionName)
        : base(human.FirstName, human.LastName, human.BirthDate)
    {
        _znoCertificatePoints = znoCertificatePoints;
        _educationDocumentPoints = educationDocumentPoints;
        _generalEducationInstitutionName = generalEducationInstitutionName;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.Write($"{_znoCertificatePoints} {_educationDocumentPoints} {_generalEducationInstitutionName} ");
    }
}
