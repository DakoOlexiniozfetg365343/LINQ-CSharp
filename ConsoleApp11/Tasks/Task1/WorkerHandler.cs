namespace ConsoleApp11.Tasks.Task1;

public class WorkerHandler
{


    public void AddWorker(Company company, Worker worker)
    {
        company.Workers.Add(worker);
    }
    public void RemoveWorker(Company company,Worker worker)
    {
        company.Workers.Remove(worker);
    }

    public IEnumerable<Worker> GetAllWorkers(Company company)
    {
        return company.Workers;
    }

    public IEnumerable<Worker> GetWorkersWithHigherSalary(Company company, decimal salary)
    {
        return company.Workers.Where(w => w.Salary > salary).ToList();
    }

    public IEnumerable<Worker> GetManagerWorkers(List<Company> companies)
    {
        return companies.SelectMany(c => c.Workers).Where(w =>
            w.Position.Equals("Manager", StringComparison.OrdinalIgnoreCase)
        ).ToList();
    }

    public IEnumerable<Worker> Get23PhoneWorkers(Company company)
    {
        return company.Workers.Where(w => w.PhoneNumber.Contains("23")).ToList();
    }
    public IEnumerable<Worker> GetdiEmailWorkers(Company company)
    {
        return company.Workers.Where(w => w.Email.StartsWith("di")).ToList();
    }

    public IEnumerable<Worker> GetLionelWorkers(Company company)
    {
        return company.Workers.Where(w => w.FirstName == "Lionel").ToList();
    }
}