using ConsoleApp.Methods;
using System;


Collatz collatz = new Collatz();
OnlyOdd onlyOdd = new OnlyOdd();
CompareAndFilter compareAndFilter = new CompareAndFilter();


List<int> array1 = new List<int>
{
  6,
  2,
  3,
};

List<int> array2 = new List<int>
{
  1,
  2,
  3,
};


compareAndFilter.execute(array1, array2);
