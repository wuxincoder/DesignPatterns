using System;
using System.Collections.Generic;
using System.Text;

namespace _06原型模式.Prototype
{
    internal class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id):base(id)
        {

        }
        public override Prototype Clone()
        {
            //浅拷贝
            return (Prototype)this.MemberwiseClone();
        }
    }
}
