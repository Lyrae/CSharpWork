using System;

namespace hw2_b2
{
    class Program
    {
        static void Main(string[] args)
        {
      int[] arr = { 5, 3, 10, 2, 4, 6,67,12,98,26,1,16};
      //maximum
      int max = arr[0];
      foreach (int i in arr)
      {
        if (i > max) max = i;      
      }
      Console.WriteLine("Maxmum is:" + max);

      //minimum
      int min = arr[0];
      foreach (int i in arr)
      {
        if (i < min) min = i;
      }
      Console.WriteLine("Minimum is:" + min);

      //average
      int sum = 0;
      foreach (int i in arr)
      {
        sum+=i;
      }
      double average = sum / arr.Length;
      Console.WriteLine("Average value is:" + average);

      //sum
      Console.WriteLine("Sum is:" + sum);
    }
    }
}                                                                                                                  
