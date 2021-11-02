using _13适配器模式.Basketball;
using _13适配器模式.Demo;
using System;

namespace _13适配器模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Target target = new Adapter();
            //target.Request();

            Player b = new Forwards("前峰1");
            b.Attach();
            Player m = new Guards("后卫1");
            m.Attach();

            Player ym = new Translator("中锋1");
            ym.Attach();
            ym.Defense();
        }
    }
}
