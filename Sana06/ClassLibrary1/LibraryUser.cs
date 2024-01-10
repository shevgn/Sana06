namespace ClassLibrary1;


public class LibraryUser : Human
{
    private int _readerTicketNumber;
    private DateTime _dateOfIssue;
    private decimal _monthlyReaderFee;

    public LibraryUser()
    {
        
    }
    
    public LibraryUser(string firstName, string lastName, DateTime birthDate, int readerTicketNumber, DateTime dateOfIssue, decimal monthlyReaderFee)
        : base(firstName, lastName, birthDate)
    {
        _readerTicketNumber = readerTicketNumber;
        _dateOfIssue = dateOfIssue;
        _monthlyReaderFee = monthlyReaderFee;
    }
    
    public LibraryUser(Human human, int readerTicketNumber, DateTime dateOfIssue, decimal monthlyReaderFee)
        : base(human.FirstName, human.LastName, human.BirthDate)
    {
        _readerTicketNumber = readerTicketNumber;
        _dateOfIssue = dateOfIssue;
        _monthlyReaderFee = monthlyReaderFee;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.Write($"{_readerTicketNumber} {_dateOfIssue.ToShortDateString()} {_monthlyReaderFee}");
    }
}