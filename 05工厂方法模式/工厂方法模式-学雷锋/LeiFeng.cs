using System;
using System.Collections.Generic;
using System.Text;

namespace _05工厂方法模式.工厂方法模式_学雷锋
{
    public class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }
        public void Wash()
        {
            Console.WriteLine("洗衣");
        }
        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }

    public class Undergraduate : LeiFeng
    {

    }
    public class Volunteer : LeiFeng
    {

    }
}
