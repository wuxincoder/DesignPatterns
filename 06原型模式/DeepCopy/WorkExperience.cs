using System;
using System.Collections.Generic;
using System.Text;

namespace _06原型模式.DeepCopy
{
    public class WorkExperience : ICloneable
    {
        public string WorkDate { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
