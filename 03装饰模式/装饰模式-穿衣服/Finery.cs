using System;
using System.Collections.Generic;
using System.Text;

namespace _03装饰模式
{
    public class Finery:Person
    {
        protected Person component;
        //打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
           if(this.component != null)
            {
                component.Show();
            }
        }
    }
}
