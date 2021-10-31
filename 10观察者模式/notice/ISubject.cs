using System;
using System.Collections.Generic;
using System.Text;

namespace _10观察者模式.notice
{
    public interface ISubject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SubjectState { get; set; }
    }


    class Boss : ISubject
    {
        private IList<Observer> _observers = new List<Observer>();
        private string _action;

        public string SubjectState { get => _action; set => _action = value; }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in _observers)
            {
                item.Update();
            }
        }

    }
}
