using System;
using System.Collections.Generic;
using System.Text;

namespace _03装饰模式
{
    public class Person
    {
        public Person()
        {

        }

        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"装扮的{name}");
        }
    }
}
