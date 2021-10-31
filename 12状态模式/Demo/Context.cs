using System;
using System.Collections.Generic;
using System.Text;

namespace _12状态模式.Demo
{
    public class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine($"当前状态：{state.GetType().Name}");
            }
        }

        public void Request()
        {
            state.Handle(this);
        }

    }
}
