using _12状态模式.Demo;
using _12状态模式.WorkState;
using System;

namespace _12状态模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Context c = new Context(new ConcreteStateA());
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();

            Work work = new Work();
            work.Hour = 9;
            work.WriteProgram();
            work.Hour = 10;
            work.WriteProgram();
            work.Hour = 12;
            work.WriteProgram();
            work.Hour = 13;
            work.WriteProgram();
            work.Hour = 14;
            work.WriteProgram();
            work.Hour = 17;
            work.WriteProgram();
            work.Hour = 19;
            work.WriteProgram();
            work.Hour = 22;
            work.WriteProgram();
           
        }
    }
}
