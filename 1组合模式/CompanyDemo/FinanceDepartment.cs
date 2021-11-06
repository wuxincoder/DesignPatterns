using System;
using System.Collections.Generic;
using System.Text;

namespace _1组合模式.CompanyDemo
{
    public class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new String('-', depth)}{name}");
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{name} 公司财务收支管理");
        }

        public override void Remove(Company c)
        {
            throw new NotImplementedException();
        }
    }
}
