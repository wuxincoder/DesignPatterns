using System;
using System.Collections.Generic;
using System.Text;

namespace _1组合模式.CompositeDemo
{
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new String('-',depth)}{name}");
            foreach (var item in children)
            {
                item.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}
