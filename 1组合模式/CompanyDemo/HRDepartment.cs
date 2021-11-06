using System;
using System.Collections.Generic;
using System.Text;

namespace _1组合模式.CompanyDemo
{
    public class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
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
            Console.WriteLine($"{name} 员工招聘培训管理");
        }

        public override void Remove(Company c)
        {
           
        }
    }
}
