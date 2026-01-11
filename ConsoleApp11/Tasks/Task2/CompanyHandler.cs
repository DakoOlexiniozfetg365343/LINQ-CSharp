using ConsoleApp11.Tasks.Task1; 
namespace ConsoleApp11.Tasks.Task2;

public class CompanyHandler
{
    public List<Company> Companies { get; set; } = new List<Company>();
    
    public void AddCompany(Company company) =>  Companies.Add(company);
    public void RemoveCompany(Company company) =>  Companies.Remove(company);
    public List<Company> GetCompanies() => Companies;

    public void ShowInfoOfAllCompanies()
    {
        foreach (var company in Companies) company.ShowInfo();
    }

    public IEnumerable<Company>  GetFoodCompanies()
    {
        var result = Companies.Where(c => c.NameOfCompany.Contains("Food"));
        return result;
    }

    public IEnumerable<Company> GetMarketingCompanies()
    {
        var result = Companies.Where(c => c.CompanyProfile == CompanyProfile.Marketing);
        return result;
    }
    public IEnumerable<Company> GetMarketingOrItCompanies()
    {
        var result = Companies.Where(c => c.CompanyProfile ==
            CompanyProfile.Marketing ||  c.CompanyProfile == CompanyProfile.It);
        return result;
    }

    public IEnumerable<Company> GetMoreThan100WorkersCompanies()
    {
        var result = Companies.Where(c => c.AmountOfWorkers > 100);
        return result;
    }

    public IEnumerable<Company> GetBetween100And300WorkersCompanies()
    {
        var result = Companies.Where(c => c.AmountOfWorkers >= 100 && c.AmountOfWorkers <= 300);
        return result;
    }

    public IEnumerable<Company> GetCompaniesFromLondon()
    {
        var result = Companies.Where(c => c.AddressOfCompany.Contains("London"));
        return result;
    }

    public IEnumerable<Company> GetCompaniesWithPrincipalsWhite()
    {
        var result = Companies.Where(c => c.LastNameOfPrincipal == "White");
        return result;
    }

    public IEnumerable<Company> GetCompaniesOlderThan2Years()
    {
        var result = Companies.Where(c => c.DateOfFoundation < DateTime.Now.AddYears(-2));
        return result;
    }

    public IEnumerable<Company> GetCompaniesOlderThan123Days()
    {
        var result = Companies.Where(c => c.DateOfFoundation <= DateTime.Now.AddDays(-123));
        return result;
    }

    public IEnumerable<Company> GetCompaniesPrincipalBlackCompanyWhite()
    {
        var result = Companies.Where(c => c.LastNameOfPrincipal == "Black" &&
                                          c.NameOfCompany.Contains("White"));
        return result;
    }
}