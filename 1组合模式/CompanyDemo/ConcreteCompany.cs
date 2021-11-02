using System;
using System.Collections.Generic;
using System.Text;

namespace _1组合模式.CompanyDemo
{
    internal class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>(); 
        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
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

        public override void LineOfDuty()
        {
            foreach (var item in children)
            {
                item.LineOfDuty();
            }
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }
    }
}
