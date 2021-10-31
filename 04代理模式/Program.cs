using System;

namespace _04代理模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //类似WebService就是代理的一种实现
            Proxy proxy = new Proxy();
            proxy.Request();
            Console.Read();
        }
    }
}
