using System;

namespace NumbersInCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      double a = 5;
      double b = 4;
      double c = 2;
      double d = (a + b) / c;
      Console.WriteLine(d);
      double e = 19;
      double f = 23;
      double g = 8;
      double h = (e + f) / g;
      Console.WriteLine(h);
      double max = double.MaxValue;
      double min = double.MinValue;
      Console.WriteLine($"The range of double is {min} to {max} and wraps {max + 0.01}");
      double third = 1.0 / 3.0;
      Console.WriteLine(third);
      double one = 1.0;
      Console.WriteLine(one);
decimal minD = decimal.MinValue;
decimal maxD = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minD} to {maxD}");

    }
  }
}
