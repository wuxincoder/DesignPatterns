using System;
using System.Collections.Generic;
using System.Text;

namespace _17单例模式
{
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() { }
        public static Singleton GetSingleton()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public class MulSingleton
    {
        private static MulSingleton instance;
        private static readonly object syncRoot = new object();
        private MulSingleton()
        {

        }

        public static MulSingleton GetSingleton()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new MulSingleton();
                    }
                }
            }
            return instance;
        }
    }

    public sealed class StaticSingleton
    {
        private static readonly StaticSingleton instance = new StaticSingleton();
        private StaticSingleton() { }
        public static StaticSingleton GetInstance()
        {
            return instance;
        }
    }
}
