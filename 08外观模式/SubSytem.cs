using System;
using System.Collections.Generic;
using System.Text;

namespace _08外观模式
{
    internal class SubSytemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }
    internal class SubSytemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }
    }
    internal class SubSytemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系统方法三");
        }
    }
    internal class SubSytemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("子系统方法四");
        }
    }
}
