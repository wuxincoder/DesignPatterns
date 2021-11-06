using System;
using System.Collections.Generic;
using System.Text;

namespace _16迭代器模式.IteratorDemo
{
    public class ConcreteAggregate : Aggregate
    {
        private IList<Object> items = new List<Object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count { get { return items.Count; } }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
