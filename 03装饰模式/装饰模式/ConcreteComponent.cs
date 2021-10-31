using System;
using System.Collections.Generic;
using System.Text;

namespace _03装饰模式
{
    public class ConcreteComponent:Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}
