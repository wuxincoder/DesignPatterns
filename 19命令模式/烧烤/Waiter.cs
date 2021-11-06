using System;
using System.Collections.Generic;
using System.Text;

namespace _19命令模式.烧烤
{
    public class Waiter
    {

        private IList<Command> orders = new List<Command>();
        public void SetOrder(Command command)
        {
            if (command.GetType() == typeof(BakeChickenWingCommand))
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine($"增加订单：{command.ToString()} 时间：{DateTime.Now}");
            }
        }

        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine($"取消订单：{command.GetType().Assembly.FullName} 时间：{DateTime.Now}");

        }

        public void Notify()
        {
            foreach (Command cmd in orders)
            {
                cmd.ExcuteCommand();
            }
        }
    }
}
