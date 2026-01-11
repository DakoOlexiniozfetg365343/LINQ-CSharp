using System.Text.RegularExpressions;

namespace ConsoleApp11.Tasks.Task1;

public class Worker
{
    private string _firstName;
    private string _lastName;
    private string _position;
    private string _phoneNumber;
    private string _email;
    private decimal _salary;
    const string phonePattern = @"^(\+380|380|0)\d{9}$";
    private const string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

    public string FirstName
    {
        get => _firstName;

        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name must not be null or empty.");
            _firstName = value;
        }

    }
    public string LastName
    {
        get => _lastName;

        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name must not be null or empty.");
            _lastName = value;
        }
    }
    public string Position
    {
        get => _position;


        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw  new ArgumentException("Position must not be null or empty.");
            _position = value;
        }
    }
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw  new ArgumentException("Phone number must not be null or empty.");
            if(!Regex.IsMatch(value, phonePattern))
                throw new  ArgumentException("Phone number must only contain letters and digits.");
            _phoneNumber = value;
        }
    }
    public string Email
    {
        get =>  _email;


        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw  new ArgumentException("Email must not be null or empty.");
            if(!Regex.IsMatch(value, emailPattern))
                throw  new ArgumentException("Email must only contain letters and digits.");
            _email = value;
        }
    }
    public decimal Salary
    {
        get => _salary;

        set
        {
            if(value < 0)
                throw new  ArgumentException("Salary must be greater than or equal to zero.");
            _salary = value;
        }
    }

    public Worker(string firstName, string lastName, string position, string phoneNumber, string email,decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        PhoneNumber = phoneNumber;
        Email = email;
        Salary = salary;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Salary: {Salary}");
    }
    
    
    
    
}