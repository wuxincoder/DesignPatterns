using System;

namespace _03装饰模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();
            //d1.SetComponent(c);
            //d2.SetComponent(d1);
            //d2.Operation();
            //// 首先用 ConcreteComponent 实例化 c
            //// 然后用 ConcreteDecoratorA 实例化对象d1包装c
            //// 再用   ConcreteDecoratorB 的对象包装d1 最终执行d2的Operation
            //Console.Read();

            Person xc = new Person("小菜");
            Console.WriteLine("第一种装扮：");
            Sneakers sneakers = new Sneakers();
            BigTrouser bigTrouser = new BigTrouser();
            TShirts shirts = new TShirts();
            sneakers.Decorate(xc);
            bigTrouser.Decorate(sneakers);
            shirts.Decorate(bigTrouser);
            shirts.Show();
            Console.WriteLine("第二种装扮：");
            LeatherShoes leatherShoes = new LeatherShoes();
            Tie tie = new Tie();
            Suit suit = new Suit();
            leatherShoes.Decorate(xc);
            tie.Decorate(leatherShoes);
            suit.Decorate(tie);
            suit.Show();

        }
    }
}
