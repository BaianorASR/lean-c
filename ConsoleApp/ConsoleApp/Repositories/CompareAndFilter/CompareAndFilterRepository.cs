namespace ConsoleApp.Repositories.CompareAndFilter;

public class CompareAndFilter
{
    public void Execute(List<int> firstList, List<int> secondList)
    {
        var filteredList = firstList.Where(x => !secondList.Contains(x)).ToList();

        Console.WriteLine(filteredList.Count > 0
            ? $"The following numbers are not in the second list: {string.Join(", ", filteredList)}"
            : "All numbers in the first list are in the second list."
        );
    }
}