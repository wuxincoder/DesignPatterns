using _09建造者模式.ProductBuild;
using System;

namespace _09建造者模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builder1 = new ConcreteBuilder1();
            Builder builder2 = new ConcreteBuilder2();

            director.Construct(builder1);
            Product p1 = builder1.GetResult();
            p1.Show();
            director.Construct(builder2);
            Product p2 = builder2.GetResult();
            p2.Show();
        }
    }
}
