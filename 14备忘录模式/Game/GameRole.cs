using System;
using System.Collections.Generic;
using System.Text;

namespace _14备忘录模式.Game
{
    public class GameRole
    {
        //生命力
        public int Vitality { get; set; }
        //攻击力
        public int Attack { get; set; }
        //防御力
        public int Defense { get; set; }

        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine($"生命力：{Vitality}");
            Console.WriteLine($"攻击力：{Attack}");
            Console.WriteLine($"防御力：{Defense}");
        }

        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(Vitality, Attack, Defense);
        }

        public void RecoveryState(RoleStateMemento memento)
        {
            Vitality = memento.Vitality;
            Attack = memento.Attack;
            Defense = memento.Defense;
        }

        public void GetInitState()
        {
            Vitality = 100;
            Attack = 100;
            Defense = 100;  
        }

        public void Fight()
        {
            Vitality = 0;
            Attack = 0;
            Defense = 0;
        }
    }
}
