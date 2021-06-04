using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
          int sum = 0;
          Random rd = new Random();
          GenericList<int> list = new GenericList<int>();
          for (int i = 0; i < 10; i++)
          {
             list.Add(rd.Next() % 100);
          }
          int max = list.Head.Data;
          int min = list.Head.Data;

          list.ForEach(n => Console.WriteLine(n));
          list.ForEach(n => sum += n);
          list.ForEach(n => { max = max > n ? max : n; });
          list.ForEach(n => { min = min < n ? min : n; });

          Console.WriteLine("最大值：" + max);
          Console.WriteLine("最小值：" + min);
          Console.WriteLine("求和：" + sum);
        }
  }
}
