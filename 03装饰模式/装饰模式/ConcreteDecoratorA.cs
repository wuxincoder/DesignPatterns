using System;
using System.Collections.Generic;
using System.Text;

namespace _03装饰模式
{
    public class ConcreteDecoratorA:Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}
