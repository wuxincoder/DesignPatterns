using System;
using System.Collections.Generic;
using System.Text;

namespace _07模板方法模式.Test
{
    public class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("题目1:选项：a： b： c： d：");
            Console.WriteLine($"答案：{Answer1()}");
        }
        public void TestQuestion2()
        {
            Console.WriteLine("题目2:选项：a： b： c： d：");
            Console.WriteLine($"答案：{Answer2()}");
        }

       
        public void TestQuestion3()
        {
            Console.WriteLine("题目3:选项：a： b： c： d：");
            Console.WriteLine($"答案：{Answer3()}");
        }

        protected virtual string Answer1()
        {
            return "";
        }
        protected virtual string Answer2()
        {
            return "";
        }
        protected virtual string Answer3()
        {
            return "";
        }

    }
}
