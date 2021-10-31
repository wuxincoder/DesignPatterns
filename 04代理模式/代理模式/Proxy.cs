using System;
using System.Collections.Generic;
using System.Text;

namespace _04代理模式
{
    internal class Proxy : Subject
    {
        RealSubject _realSubject;
        public override void Request()
        {
            if( _realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}
