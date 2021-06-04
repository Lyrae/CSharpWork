using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
          Clock clock = new Clock();
          DateTime atime = new DateTime();
          atime = DateTime.Now.AddSeconds(3);  //设定闹钟检验alarm事件

          clock.SetAlarmTime(atime);
          clock.Start();
        }
    }
}
