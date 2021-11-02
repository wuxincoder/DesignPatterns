using _14备忘录模式.Game;
using _14备忘录模式.MementoDemo;
using System;

namespace _14备忘录模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameRole game = new GameRole();
            game.GetInitState();
            game.StateDisplay();
            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = game.SaveState();
            game.Fight();
            game.StateDisplay();
            game.RecoveryState(stateAdmin.Memento);

            game.StateDisplay();

            //Originator o = new Originator();
            //o.State = "on";
            //o.Show();
            //Caretaker c = new Caretaker();
            //c.Memento = o.CreateMemento();
            //o.State = "off";
            //o.Show();
            //o.SetMemento(c.Memento);
            //o.Show();
        }
    }
}
