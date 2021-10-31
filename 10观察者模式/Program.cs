//using _10观察者模式.notice;
using _10观察者模式.PublishSubscribe;
using System;

namespace _10观察者模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boss boss = new Boss();
            //StockObserver ts1 = new StockObserver("小花", boss);
            //NBAObserver ts2 = new NBAObserver("小名", boss);

            //boss.Attach(ts1);
            //boss.Attach(ts2);
            ////boss.Detach(ts1);
            //boss.SubjectState = "老板来了";
            //boss.Notify();


            //ConcreteSubject s = new ConcreteSubject();
            //s.Attach(new ConcreteObserver(s, "X"));
            //s.Attach(new ConcreteObserver(s, "Y"));
            //s.Attach(new ConcreteObserver(s, "Z"));

            //s.SubjectState = "ABC";
            //s.Notify();
            Boss boss = new Boss();
            StockObserver ts1 = new StockObserver("小花", boss);
            NBAObserver ts2 = new NBAObserver("小名", boss);

            boss.Update += ts1.CloseStock;
            boss.Update += ts2.CloseNBA;

            boss.SubjectState = "老板回来了！！！ ";
            boss.Notify();

        }
    }
}
