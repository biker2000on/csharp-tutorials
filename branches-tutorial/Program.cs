using System;

namespace BranchesAndLoops
{
  class Program
  {
    static void ExploreIf()
    {
      int a = 5;
      int b = 3;
      if (a + b > 10)
      {
        Console.WriteLine("The answer is greater than 10");
      }
      else
      {
        Console.WriteLine("The answer is not greater than 10");
      }

      int c = 4;
      if ((a + b + c > 10) && (a > b))
      {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is greater than the second");
      }
      else
      {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not greater than the second");
      }

      if ((a + b + c > 10) || (a > b))
      {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
      }
      else
      {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
      }
    }

    static void Main(string[] args)
    {
      // ExploreIf();
      // int counter = 0;
      // do
      // {
      //   Console.WriteLine($"The counter is {counter}");
      //   counter++;
      // } while (counter <= 10);

      // for (int i = 0; i <= 10; i++)
      // {
      //   Console.WriteLine($"Hello World! Index is {i}");
      // }

      for (int j = 0; j <= 10; j++) {
        for (int k = 0; k <= 10; k++) {
          Console.Write($"({j},{k}), ");
        }
        Console.Write('\n');
      }
    }
  }
}
