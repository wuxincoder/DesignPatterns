using System;

namespace _01简单工厂
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation oper = OperationFactory.createOperate("+");

            oper.NumberA = 1;
            oper.NumberB = 2;
            
            double result = oper.GetResult();
            
        }
    }
}
