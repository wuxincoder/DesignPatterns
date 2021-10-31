using System;
using System.Collections.Generic;
using System.Text;

namespace _07模板方法模式.TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine();
        }

    }
}
