using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    public class SqlServerUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SQL Server中给User表添加一条记录");
        }
        public User Get(int id)
        {
            Console.WriteLine("在SQL Server中根据id获取User表一条记录");
            return null;
        }
    }

    public class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access中给User表添加一条记录");
        }
        public User Get(int id)
        {
            Console.WriteLine("在Access中根据id获取User表一条记录");
            return null;
        }
    }
}
