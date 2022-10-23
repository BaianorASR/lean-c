namespace ConsoleApp.Repositories.OnlyOdd;

public class OnlyOdd
{
    public void Execute(List<int> numbers)
    {
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

        Console.WriteLine(
            oddNumbers.Count == 0
                ? "There are no odd numbers in the list."
                : $"The odd numbers in the list are: {string.Join(", ", oddNumbers)}"
        );
    }
}