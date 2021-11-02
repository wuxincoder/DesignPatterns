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

    public class ForeignCenter
    {
        public string Name { get; set; }
        public void 进攻()
        {
            Console.WriteLine($"外籍中锋 {Name} 进攻");
        }
        public void 防守()
        {
            Console.WriteLine($"外籍中锋 {Name} 防守");
        }
    }

    class Translator : Player
    {
        private ForeignCenter wjzf = new ForeignCenter();
        public Translator(string name) : base(name)
        {
            wjzf.Name = name;
        }

        public override void Attach()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }


}
