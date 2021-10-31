using System;
using System.Collections.Generic;
using System.Text;

namespace _03装饰模式
{
    public class ConcreteDecoratorB:Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }
        //本类独有的方法，以区别于ConcreteDecoratorB
        private void AddedBehavior()
        {
            throw new NotImplementedException();
        }
    }
}
