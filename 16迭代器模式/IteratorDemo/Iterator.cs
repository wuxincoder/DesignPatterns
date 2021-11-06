using System;
using System.Collections.Generic;
using System.Text;

namespace _16迭代器模式.IteratorDemo
{
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();

    }
}
