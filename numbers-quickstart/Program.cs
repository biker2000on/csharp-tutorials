using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 2;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
            Console.WriteLine(c.GetType());
            int d = (int)Math.Pow((double)a,(double)b);
            Console.WriteLine(d);
            // c = a ** b;
            // Console.WriteLine(c);
        }
    }
}
