using System;
using System.Collections.Generic;
using System.Text;

namespace _02策略模式
{
    internal class Context
    {

        Strategy strategy;

        public Context(Strategy strategy)//初始化时，传入具体的策略对象
        {
            this.strategy = strategy;
        }

        public void ContextInterface()//根据具体的策略对象，调用其算法的方法
        {
            strategy.AlgorithmInterface();
        }
    }
}
