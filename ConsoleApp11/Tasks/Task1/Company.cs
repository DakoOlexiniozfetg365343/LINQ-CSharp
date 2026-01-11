namespace ConsoleApp11.Tasks.Task1;

public class Company
{
    private string _companyName;
    private DateTime _dateOfFoundation;
    private CompanyProfile _companyProfile;
    private string _firstNameOfPrincipal;
    private string _lastNameOfPrincipal;
    private string _addressOfCompany;
    public List<Worker> Workers { get; set; } = new List<Worker>();
    public int AmountOfWorkers => Workers.Count;

    public string NameOfCompany
    {
        get => _companyName;

        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new  ArgumentException("NameOfCompany must not be empty.");
            _companyName = value;
        }
    }

    public DateTime DateOfFoundation
    {
        get => _dateOfFoundation;

        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("DateOfFoundation must not be in the future.");
            if(value.Year < 1700)
                throw new ArgumentException("DateOfFoundation must not be in ancient times.");
            _dateOfFoundation = value;
        }
    }
    
    public CompanyProfile CompanyProfile { get; set; }

    public string FirstNameOfPrincipal
    {
        get => _firstNameOfPrincipal;

        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name can not be empty");
            _firstNameOfPrincipal = value;
        }
    }

    public string LastNameOfPrincipal
    {
        get => _lastNameOfPrincipal;

        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name can not be empty");
            _lastNameOfPrincipal = value;
        }
    }
    

    public string AddressOfCompany
    {
        get => _addressOfCompany;
        
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new  ArgumentException("AddressOfCompany Must not be empty.");
            _addressOfCompany = value;
        }
    }

    public Company(string nameOfCompany, DateTime date, CompanyProfile profile,
        string principalFirst,string principalLast, string addressOfCompany)
    {
        NameOfCompany = nameOfCompany;
        DateOfFoundation = date;
        CompanyProfile = profile;
        FirstNameOfPrincipal = principalFirst;
        LastNameOfPrincipal = principalLast;
        AddressOfCompany = addressOfCompany;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"NameOfCompany: {NameOfCompany}");
        Console.WriteLine($"DateOfFoundation: {DateOfFoundation}");
        Console.WriteLine($"CompanyProfile: {CompanyProfile}");
        Console.WriteLine($"First name of Principal: {FirstNameOfPrincipal}");
        Console.WriteLine($"Last name of Principal: {LastNameOfPrincipal}");
        Console.WriteLine($"AmountOfWorkerks: {AmountOfWorkers}");
        Console.WriteLine($"AddressOfCompany: {AddressOfCompany}");
    }
}