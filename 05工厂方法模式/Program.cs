
using _05工厂方法模式.工厂方法模式_学雷锋;
using System;

namespace _05工厂方法模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IFactory operFactory = new AddFactory();
            //Operation oper = operFactory.CreateOperation();
            //oper.NumberA = 1;
            //oper.NumberB = 1;
            //double result = oper.GetResult();
            IFactory factory = new UndergraduateFactory();
            LeiFeng leiFeng =factory.CreateLeiFeng();
            leiFeng.BuyRice();
            leiFeng.Sweep();
            leiFeng.Wash();

        }
    }
}
