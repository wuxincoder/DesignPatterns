using System;
using System.Collections.Generic;
using System.Text;

namespace _03装饰模式
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }
    public class Sneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Sneakers");
            base.Show();
        }
    }

    public class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("LeatherShoes");
            base.Show();
        }
    }
    public class Tie : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Tie");
            base.Show();
        }
    }
    public class Suit : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Suit");
            base.Show();
        }
    }
}
