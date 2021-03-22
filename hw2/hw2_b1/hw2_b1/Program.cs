using System;

namespace hw2_b1
{
    class Program
    {
        static void Main(string[] args)
        {
      int num;
      Console.Write("Please enter a positive integer:");
      num=int.Parse(Console.ReadLine());
      Console.Write("Prime factors are:");
      while (num != 1)
      {
        for (int i = 2; i <= num; i++)
        {
          if (num % i == 0)
          {
            num = num / i;
            Console.Write(i + " ");
            break;
          }
        }
      }
    }
      
    }
}
