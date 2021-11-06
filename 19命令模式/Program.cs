//using _19命令模式.烧烤;
using _19命令模式.命令模式;
using System;

namespace _19命令模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Barbecuer boy = new Barbecuer();
            //Command cmd1 = new BakeMuttonCommand(boy);
            //Command cmd2 = new BakeMuttonCommand(boy);
            //Command cmd3 = new BakeChickenWingCommand(boy);

            //Waiter girl = new Waiter();
            //girl.SetOrder(cmd1);
            //girl.SetOrder(cmd2);
            //girl.SetOrder(cmd3);

            //girl.Notify();


            Receiver r = new Receiver();
            Command cmd = new ConcreteCommand(r);
            Invoker i = new Invoker();
            i.SetCommand(cmd);
            i.ExcuteCommand();
        }
    }
}
