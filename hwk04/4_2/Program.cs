using System;
using System.Threading;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.OnTick += new TickHandler(Program.Clock_Tick);
            clock.OnAlarm += new AlarmHandler(Program.Clock_Alarm);
            Console.WriteLine("请设置闹钟的时间(时，分，秒)");
            int hour = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            clock.AlarmTime = new Time(hour, minute, second);

            clock.Start();

        }
        static void Clock_Tick(object sender,Time time)
        {
            Console.WriteLine("现在是{0}:{1}:{2}", time.Hour, time.Minute, time.Second);
        }
        static void Clock_Alarm(object sender,Time time)
        {
            Console.WriteLine("时间到了，该做事情了");
        }
    }
    //定义时间类型
    public class Time
    {
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public int Hour
        {
            get; set;
        }
        public int Minute
        {
            get; set;
        }
        public int Second
        {
            get; set;
        }

        //重写Equals方法
        public override bool Equals(object obj)
        {
            return obj is Time time &&
                   Hour == time.Hour &&
                   Minute == time.Minute &&
                   Second == time.Second;
        }
    }

    //定义两个委托类型，分别监听滴答和响铃事件
    public delegate void TickHandler(object sender,Time time);
    public delegate void AlarmHandler(object sender,Time time);


    class Clock
    {
        //定义两个委托实例，一个tick，一个alarm
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;

        private Time currentTime;

        private Time alarmTime;
        
        public Clock()
        {
            //使用系统当前时间
            DateTime time = System.DateTime.Now;
            currentTime = new Time(time.Hour, time.Minute, time.Second);
            
        }
  
        public Time AlarmTime
        {
            get { return alarmTime; }
            //闹钟的合法性检查
            set
            {
                bool flag1 = value.Hour < 0 || value.Hour >= 24;
                bool flag2 = value.Minute < 0 || value.Minute >= 60;
                bool flag3 = value.Second < 0 || value.Second >= 60;
                if (flag1 || flag2 || flag3)
                    throw new ArgumentException("设置的闹钟时间非法!!");
                this.alarmTime = value;
            }
        }

        public Time CurrentTime
        {
            get => currentTime;
        }



        public void Tick()
        {
            DateTime time = System.DateTime.Now;
            currentTime.Hour = time.Hour;
            currentTime.Minute = time.Minute;
            currentTime.Second = time.Second;
            OnTick(this,currentTime);
        }

        public void Alarm()
        {
            OnAlarm(this,currentTime);
        }

        //开启闹钟
        public void Start()
        {
            while(true)
            {
                //每隔一秒闹钟滴答一次
                Thread.Sleep(1000);
                Tick();
                if(alarmTime!=null&&currentTime.Equals(alarmTime))
                {
                    Alarm();
                    //break;
                }
            }
        }
    }
}
