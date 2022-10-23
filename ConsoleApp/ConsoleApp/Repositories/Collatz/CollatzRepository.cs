namespace ConsoleApp.Repositories.Collatz;

public class Collatz
{
    public void Execute()
    {
        var biggestSequence = 0;
        var biggestSequenceNumber = 0;


        for (var i = 1; i < 100000; i++)
        {
            var sequence = 0;
            var number = i;

            while (number != 1)
            {
                if (number % 2 == 0) number /= 2;
                else number = number * 3 + 1;
                sequence++;
            }

            if (sequence <= biggestSequence) continue;
            biggestSequence = sequence;
            biggestSequenceNumber = i;
        }


        Console.WriteLine(
            $"Biggest sequence of 1 million is {biggestSequenceNumber} with {biggestSequence} steps"
        );
    }
}