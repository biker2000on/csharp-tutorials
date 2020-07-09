using System;

namespace NumbersInCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 7;
      int b = 4;
      int c = 3;
      int d = (a + b) / c;
      int e = (a + b) % c;
      Console.WriteLine($"quotient: {d}");
      Console.WriteLine($"remainder: {e}");
      int max = int.MaxValue;
      int min = int.MinValue;
      Console.WriteLine($"The range of integers is {min} to {max}");
      Console.WriteLine($"What happens if I add 1 to max: {max + 1}");
    }
  }
}
