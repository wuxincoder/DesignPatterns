using System;
using System.Collections.Generic;
using System.Text;

namespace _10观察者模式.PublishSubscribe
{
    public abstract class Observer
    {
        public abstract void Update();
    }

   public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        public ConcreteSubject Subject { get; set; }

        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.Subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            _observerState = Subject.SubjectState;
            Console.WriteLine($"观察者{_name}的新状态{_observerState}");
        }
    }
}
