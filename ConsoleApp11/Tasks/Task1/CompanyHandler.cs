using System.Globalization;

namespace ConsoleApp11.Tasks.Task1;

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
        var result = 
            from c in Companies 
            where c.NameOfCompany.Contains("Food")
            select c;
        return result;
    }

    public IEnumerable<Company> GetMarketingCompanies()
    {
        var result = from c in Companies 
            where c.CompanyProfile == CompanyProfile.Marketing
            select c; 
        return result;
    }
    public IEnumerable<Company> GetMarketingOrItCompanies()
    {
        var result = from c in Companies 
            where new[] {CompanyProfile.Marketing,CompanyProfile.It}.Contains(c.CompanyProfile)
            select c; 
        return result;
    }

    public IEnumerable<Company> GetMoreThan100WorkersCompanies()
    {
        var result = 
            from c in Companies 
            where c.AmountOfWorkers > 100
            select c;
        return result;
    }

    public IEnumerable<Company> GetBetween100And300WorkersCompanies()
    {
        var result =
            from c in Companies
            where c.AmountOfWorkers >= 100 && c.AmountOfWorkers <= 300
            select c;
        return result;
    }

    public IEnumerable<Company> GetCompaniesFromLondon()
    {
        var result =
            from c in Companies
            where c.AddressOfCompany.Contains("London")
            select c;
        return result;
    }

    public IEnumerable<Company> GetCompaniesWithPrincipalsWhite()
    {
        var result =
            from c in Companies
            where c.LastNameOfPrincipal == "White"
            select c;
        return result;
    }

    public IEnumerable<Company> GetCompaniesOlderThan2Years()
    {
        var result =
            from c in Companies
            where c.DateOfFoundation < DateTime.Now.AddYears(-2)
            select c;

        return result;
    }

    public IEnumerable<Company> GetCompaniesOlderThan123Days()
    {
        var result =
            from c in Companies
            where c.DateOfFoundation <= DateTime.Now.AddDays(-123)
            select c;
        return result;
    }

    public IEnumerable<Company> GetCompaniesPrincipalBlackCompanyWhite()
    {
        var result = 
        from c in Companies
        where c.LastNameOfPrincipal == "Black" &&  c.NameOfCompany.Contains("White")
        select c;
        return result;
    }
}