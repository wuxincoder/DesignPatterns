using System;
using System.Collections.Generic;
using System.Text;

namespace _10观察者模式
{
    public interface ISubject
    {
     
        void Notify();
        string SubjectState { get; set; }
    }

    delegate void EventHandler();
    class Boss : ISubject
    {
        public event EventHandler Update;
        //private string _action;

        public string SubjectState { get; set; }

        

        public void Notify()
        {
            Update();
        }

    }
}
