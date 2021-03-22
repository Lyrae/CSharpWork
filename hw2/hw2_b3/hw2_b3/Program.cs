using System;

namespace hw2_b3
{
    class Program
    {
        static void Main(string[] args)
        {
      int[] prime=new int[100];
      bool[] isPrime = new bool[100];

      int p = 0;
      for (int i = 0; i < 100; i++)
      {
        isPrime[i] = true;
      }

      isPrime[0] = false;

      for (int i = 2; i < 100; i++)
      {
        if (isPrime[i])
        {
          prime[p++] = i;
          for (int j = 2 * i; j < 100; j += i) isPrime[j] = false;
        }
      }

      Console.WriteLine("2-100间的质数有：");
      for (int i = 0; i < p; i++)
      {
        Console.Write(prime[i]+" ");
      }

        }
    }
}
