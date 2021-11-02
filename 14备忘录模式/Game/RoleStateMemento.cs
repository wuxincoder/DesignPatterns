namespace _14备忘录模式.Game
{
    public class RoleStateMemento
    {
        public RoleStateMemento(int vitality, int attack, int defense)
        {
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
        }

        public int Vitality { get; }
        public int Attack { get; }
        public int Defense { get; }
    }
}