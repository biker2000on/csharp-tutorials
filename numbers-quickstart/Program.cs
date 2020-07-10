using System;

namespace NumbersInCSharp
{
  class Program
  {
    static void CircleArea()
    {
      double r = 2.50;
      double area = Math.PI * r * r;
      Console.WriteLine(area);
    }
    static void Main(string[] args)
    {
      double a = 1.0;
      double b = 3.0;
      Console.WriteLine(a / b);

      decimal c = 1.0M;
      decimal d = 3.0M;
      Console.WriteLine(c / d);

      CircleArea();
    }
  }
}
