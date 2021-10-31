using System;
using System.Collections.Generic;
using System.Text;

namespace _07模板方法模式.Test
{
    public class TestPaperA : TestPaper
    {
        protected override string Answer1()
        {
            return "A";
        }
        protected override string Answer2()
        {
            return "B";
        }
        protected override string Answer3()
        {
            return "C";
        }
    }
    public class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "A";
        }
        protected override string Answer2()
        {
            return "B";
        }
        protected override string Answer3()
        {
            return "C";
        }
    }
}
