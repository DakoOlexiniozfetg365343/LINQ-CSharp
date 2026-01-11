namespace ConsoleApp11.Tasks.Task1;

public class Task1
{
    public static void Run()
    {
        List<Company> companies = new List<Company>
        {
            new Company("Foodies Inc", new DateTime(2018, 5, 12), CompanyProfile.Food, "Alice", "White", "London"),
            new Company("TechFlow", new DateTime(2020, 3, 5), CompanyProfile.It, "Bob", "Black", "New York"),
            new Company("MarketMinds", new DateTime(2019, 7, 20), CompanyProfile.Marketing, "Carol", "Green", "London"),
            new Company("GreenFood Ltd", new DateTime(2021, 1, 15), CompanyProfile.Food, "David", "Brown", "Paris"),
            new Company("Innovate IT", new DateTime(2017, 11, 30), CompanyProfile.It, "Eve", "White", "Berlin"),
            new Company("AdVision", new DateTime(2015, 6, 1), CompanyProfile.Marketing, "Frank", "Black", "London"),
            new Company("Healthy Foods", new DateTime(2022, 9, 10), CompanyProfile.Food, "Grace", "Gray", "Madrid"),
            new Company("IT Solutions", new DateTime(2016, 2, 25), CompanyProfile.It, "Hank", "White", "New York"),
            new Company("MarketBoost", new DateTime(2018, 12, 5), CompanyProfile.Marketing, "Ivy", "Black", "London"),
            new Company("White & Co", new DateTime(2019, 8, 18), CompanyProfile.Finance, "Jack", "Black", "London")
        };

        CompanyHandler handler = new CompanyHandler { Companies = companies };

        Console.WriteLine("=== ALL COMPANIES ===");
        handler.ShowInfoOfAllCompanies();

        WorkerHandler workerHandler = new WorkerHandler();

        
        workerHandler.AddWorker(companies[0], new Worker("Lionel", "Messi", "Manager", "0231111111", "di.messi@gmail.com", 5000));
        workerHandler.AddWorker(companies[0], new Worker("John", "Smith", "Cook", "0232222222", "john@gmail.com", 2000));
        workerHandler.AddWorker(companies[0], new Worker("Alice", "Brown", "Accountant", "0233333333", "di.alice@gmail.com", 2500));

        workerHandler.AddWorker(companies[1], new Worker("Bob", "Marley", "Developer", "0234444444", "bob@tech.com", 4000));
        workerHandler.AddWorker(companies[1], new Worker("Sarah", "Connor", "Manager", "0235555555", "di.sarah@tech.com", 6000));

        workerHandler.AddWorker(companies[2], new Worker("Lionel", "Richie", "Designer", "0236666666", "lionel@design.com", 3000));
        workerHandler.AddWorker(companies[2], new Worker("Mike", "Tyson", "Manager", "0237777777", "mike@mm.com", 4500));

        workerHandler.AddWorker(companies[4], new Worker("Tony", "Stark", "Manager", "0238888888", "di.tony@it.com", 10000));

      

        Console.WriteLine("\n--- All workers in Foodies Inc ---");
        foreach (var w in workerHandler.GetAllWorkers(companies[0]))
            w.ShowInfo();

        Console.WriteLine("\n--- Workers in Foodies Inc with salary > 3000 ---");
        foreach (var w in workerHandler.GetWorkersWithHigherSalary(companies[0], 3000))
            w.ShowInfo();

        Console.WriteLine("\n--- Managers from ALL companies ---");
        foreach (var w in workerHandler.GetManagerWorkers(companies))
            w.ShowInfo();

        Console.WriteLine("\n--- Workers in TechFlow with phone containing '23' ---");
        foreach (var w in workerHandler.Get23PhoneWorkers(companies[1]))
            w.ShowInfo();

        Console.WriteLine("\n--- Workers in Innovate IT with email starting 'di' ---");
        foreach (var w in workerHandler.GetdiEmailWorkers(companies[4]))
            w.ShowInfo();

        Console.WriteLine("\n--- Workers named Lionel in MarketMinds ---");
        foreach (var w in workerHandler.GetLionelWorkers(companies[2]))
            w.ShowInfo();
    }
}
