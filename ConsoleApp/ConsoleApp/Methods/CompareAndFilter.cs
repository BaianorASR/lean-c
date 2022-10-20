using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Methods
{
  internal class CompareAndFilter
  {
    public void execute(List<int> firstList, List<int> secondList)
    {
      Console.WriteLine("Executing CompareAndFilter...");
      List<int> filteredList = firstList.Where(x => !secondList.Contains(x)).ToList();

      if (filteredList.Count > 0)
      {
        Console.WriteLine("The following numbers are not in the second list:");
        foreach (int number in filteredList)
        {
          Console.WriteLine(number);
        }
      }
      else
      {
        Console.WriteLine("All numbers in the first list are in the second list.");
      }
    }
  }
}
