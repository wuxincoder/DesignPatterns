using System;
using System.Collections.Generic;
using System.Text;

namespace _04代理模式
{
    internal class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求");
        }
    }
}
