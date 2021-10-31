using System;
using System.Collections.Generic;
using System.Text;

namespace _06原型模式.DeepCopy
{
    internal class Resume : ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private WorkExperience _workExperience;
        public Resume(string name)
        {
            _name = name;
            _workExperience = new WorkExperience(); 
        }

        private Resume(WorkExperience work)
        {
            _workExperience = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this._sex = sex;
            this._age = age;
        }

        public void SetWorkExperience(string workDate, string company)
        {
            _workExperience.WorkDate = workDate;
            _workExperience.Company = company;  
        }

        public void Display()
        {
            Console.WriteLine($"{_name}{_sex}{_age}");
            Console.WriteLine($"工作经历：{_workExperience.WorkDate}{_workExperience.Company}");
            Console.WriteLine();
        }
        public object Clone()
        {
            Resume obj = new Resume(this._workExperience);
            obj._name = _name;
            obj._sex = _sex;
            obj._age = _age;
            return obj;

        }
    }
}
