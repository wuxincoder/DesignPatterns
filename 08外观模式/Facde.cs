using System;
using System.Collections.Generic;
using System.Text;

namespace _08外观模式
{
    internal class Facde
    {
        SubSytemOne one;
        SubSytemTwo two;
        SubSytemThree three;
        SubSytemFour four;

        public Facde()
        {
            one = new SubSytemOne();
            two = new SubSytemTwo();
            three = new SubSytemThree();
            four = new SubSytemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n 方法组A() ---");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("\n 方法组B() ---");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
