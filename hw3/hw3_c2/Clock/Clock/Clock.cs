using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
  class Clock
  {
    DateTime alarmTime = DateTime.Now;

    public delegate void AlarmHandler(object sender, DateTime args);
    public delegate void TickHanlder(object sender, DateTime args);

    public event AlarmHandler OnAlarm;
    public event TickHanlder OnTick;

    public Clock()
    {
      OnAlarm += Alarm;
      OnTick += Tick;
    }

    public void Alarm(object sender, DateTime time)
    {
      Console.WriteLine(time + ":响铃");
    }

    public void Tick(object sender, DateTime time)
    {
      Console.WriteLine("tick：" + time);
    }

    public void Start()
    {
      while (true)
      {
        DateTime now = DateTime.Now;
        OnTick(this, now);
        if (now.ToString() == alarmTime.ToString())
        {
          OnAlarm(this, alarmTime);
        }
        System.Threading.Thread.Sleep(1000);
      }
    }

    public void SetAlarmTime(DateTime time)
    {
      //Console.WriteLine(time);
      alarmTime = time;
    }
  }
}
