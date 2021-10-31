using System;
using System.Collections.Generic;
using System.Text;

namespace _12状态模式.WorkState
{
    public abstract class State
    {
        public abstract void WriteProgram(Work w);
    }

    public class ForenoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if(w.Hour < 12)
            {
                Console.WriteLine($"现在：{w.Hour} 点 上午 刚开始工作");
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }
    public class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine($"现在：{w.Hour} 点 中午 吃饭 午休");
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();

            }
        }
    }
    public class AfternoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 18)
            {
                Console.WriteLine($"现在：{w.Hour} 点 下午 工作中");
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();

            }
        }
    }
    public class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine($"现在：{w.Hour} 点 加班 996ing");
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();

                }
            }
            
        }
    }
    public class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine($"现在：{w.Hour} 点 不干了，老子睡觉");
        }
    }
    public class RestState : State
    {
        public override void WriteProgram(Work w)
        {
            throw new NotImplementedException();
        }
    }
}
