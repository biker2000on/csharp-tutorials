using System;
using System.Collections.Generic;

namespace list_tutorial
{
  class Program
  {
    static void Main(string[] args)
    {
      // WorkingWithStrings();

      var fibonacciNumbers = new List<int> { 1, 1 };
      while (fibonacciNumbers.Count < 20)
      {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        fibonacciNumbers.Add(previous + previous2);
      }

      foreach (var item in fibonacciNumbers)
        Console.WriteLine(item);
    }

    static void WorkingWithStrings()
    {
      var names = new List<string> { "Justin", "Ana", "Felipe" };
      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}");
      }
      Console.WriteLine($"My name is {names[0]}");
      Console.WriteLine($"The other names are {names[1]} and {names[2]} with a total of {names.Count}");
      var index = names.IndexOf("Felipe");
      if (index == -1)
      {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
      }
      else
      {
        Console.WriteLine($"The name {names[index]} is at index {index}");
      }

      index = names.IndexOf("Not Found");
      if (index == -1)
      {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
      }
      else
      {
        Console.WriteLine($"The name {names[index]} is at index {index}");

      }

      names.Sort();
      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}
