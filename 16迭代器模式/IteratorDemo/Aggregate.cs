using System;
using System.Collections.Generic;
using System.Text;

namespace _16迭代器模式.IteratorDemo
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
