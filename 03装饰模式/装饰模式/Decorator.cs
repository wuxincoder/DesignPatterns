using System;
using System.Collections.Generic;
using System.Text;

namespace _03装饰模式
{
    public abstract class Decorator:Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if(component != null)
            {
                component.Operation();
            }
        }
    }
}
