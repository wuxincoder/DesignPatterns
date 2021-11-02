using System;
using System.Collections.Generic;
using System.Text;

namespace _1组合模式.CompanyDemo
{
    abstract public class Company
    {
        protected string name;
        public Company(string name)
        {
            this.name = name;
        }
        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        public abstract void LineOfDuty();
    }
}
