namespace ConsoleApp11.Tasks.Task3;


public class Task3
{
    public static void Run()
    {
        ListHandler hand =  new ListHandler();
        List<int> myList = new List<int>([121,75,81]);
        var updatedList = hand.SpecialSort(myList,false);
        foreach (var item in updatedList)
        {
            Console.WriteLine(item);
        }
    }
}
