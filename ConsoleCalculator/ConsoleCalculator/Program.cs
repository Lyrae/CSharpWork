using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
      while (true)
      {
        double a, b, result;
        string oper;
        Console.WriteLine("Please enter the first number:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the operator");
        oper = Console.ReadLine();
        Console.WriteLine("Please enter the second number:");
        b = double.Parse(Console.ReadLine());

        switch (oper)
        {
          case "+":
            result = a + b;
            Console.WriteLine("The result is " + result);
            break;
          case "-":
            result = a - b;
            Console.WriteLine("The result is " + result);
            break;
          case "*":
            result = a * b;
            Console.WriteLine("The result is " + result);
            break;
          case "/":
            if (b == 0) { Console.WriteLine("Math error!"); break; }
            else result = a / b;
            Console.WriteLine("The result is " + result);
            break;
          default:
            Console.WriteLine("input invalid");
            break;
        }
        Console.WriteLine("------------------------");
      }
    }
    }
}
