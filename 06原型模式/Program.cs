using System;
using _06原型模式.DeepCopy;
namespace _06原型模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大神");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1997-2000", "xx公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "xu公司");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("男", "24");

            c.SetWorkExperience("2001-2005", "zz公司");

            a.Display();
            b.Display();
            c.Display();

        }
    }
}
