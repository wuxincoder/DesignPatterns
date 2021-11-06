using System;
using System.Collections.Generic;
using System.Text;

namespace _16迭代器模式.IteratorDemo
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _concreteAggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
        }

        public override object CurrentItem()
        {
            return _concreteAggregate[current];
        }

        public override object First()
        {
            return _concreteAggregate[0];
        }

        public override bool IsDone()
        {
            return current >= _concreteAggregate.Count ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < _concreteAggregate.Count)
            {
                ret = _concreteAggregate[current];
            }
            return ret;
        }
    }
}
