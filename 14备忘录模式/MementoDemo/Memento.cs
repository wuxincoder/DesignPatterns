using System;
using System.Collections.Generic;
using System.Text;

namespace _14备忘录模式.MementoDemo
{
    public class Memento
    {
       
        public string State { get; set; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
