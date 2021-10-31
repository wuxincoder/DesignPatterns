using System;
using System.Collections.Generic;
using System.Text;

namespace _06原型模式.Prototype
{
    public abstract class Prototype
    {
        private string id;
        public Prototype(string id)
        {
            this.id = id;
        }
        public string Id { get { return this.id; } }

        //关键方法
        public abstract Prototype Clone();
    }
}
