namespace ConsoleApp11.Tasks.Task3;

public class ListHandler
{
    /*public List<int> specialSort(List<int> numbers,bool isAscending)
    {
        List<Tuple<int, int>> myList = new List<Tuple<int, int>>();
        foreach (var n in numbers)
        {
            Tuple<int, int> myTup = new Tuple<int, int>(n,getSumOfNumber(n));
            myList.Add(myTup);
        }

        if (isAscending)
        {
            var sortedList = myList.OrderBy(x => x.Item2).ToList();
            var finalList = sortedList.Select(x => x.Item1).ToList();
            return finalList;
        }
        else
        {
            var sortedList = myList.OrderByDescending(x => x.Item2).ToList();
            var finalList = sortedList.Select(x => x.Item1).ToList();
            return finalList;
        }
        

     } З    самого початку я зробив так))))) а потім було цікаво як це зробили інші і поняв що все набагато легше)*/ 
    
    public List<int> SpecialSort(List<int> numbers, bool isAscending)
    {
        return isAscending ? numbers.OrderBy(GetSumOfNumber).ToList() : 
            numbers.OrderByDescending(GetSumOfNumber).ToList();
    }

    private static int GetSumOfNumber(int number)
    {
        var total = 0;
        var stringNum = number.ToString();
        foreach (var n in stringNum){
            int newNumber = n - '0';
            total += newNumber;
        }
        return total;
    }
}