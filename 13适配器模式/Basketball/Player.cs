using System;
using System.Collections.Generic;
using System.Text;

namespace _13适配器模式.Basketball
{
    public abstract class Player
    {
        protected string _name;
        public Player(string name)
        {
            _name = name;
        }

        public abstract void Attach();
        public abstract void Defense();
    }

    class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }

        public override void Attach()
        {
            Console.WriteLine($"前锋 {_name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"前锋 {_name} 防御");
        }
    }
    class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attach()
        {
            Console.WriteLine($"中锋 {_name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"中锋 {_name} 防御");
        }
    }

    class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }

        public override void Attach()
        {
            Console.WriteLine($"后卫 {_name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"后卫 {_name} 防御");
        }
    }

}
