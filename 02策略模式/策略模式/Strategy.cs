using System;
using System.Collections.Generic;
using System.Text;

namespace _02策略模式
{
    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }
    /// <summary>
    /// 具体策略A
    /// </summary>
    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }
    /// <summary>
    /// 具体策略B
    /// </summary>
    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }
    /// <summary>
    /// 具体策略B
    /// </summary>
    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }
}
