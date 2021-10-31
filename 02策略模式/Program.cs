﻿using System;

namespace _02策略模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context;
            //由于实例化不同的策略，所以最终在调用时，所获得的结果就不尽相同
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }
    }
}
