using _07模板方法模式.TemplateMethod;
using _07模板方法模式.Test;
using System;

namespace _07模板方法模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("学生A抄的");
            //TestPaper studentA = new TestPaperA();
            //studentA.TestQuestion1();
            //studentA.TestQuestion2();
            //studentA.TestQuestion3();

            //Console.WriteLine("学生B抄的");

            //TestPaper studentB = new TestPaperB();
            //studentB.TestQuestion1();
            //studentB.TestQuestion2();
            //studentB.TestQuestion3();
            AbstractClass c;
            c = new ConcreteClassA();
            c.TemplateMethod();
            c = new ConcreteClassB();
            c.TemplateMethod();
        }
    }
}
