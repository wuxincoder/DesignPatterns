using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    public interface IUser
    {
        void Insert(User user);
        User Get(int id);
    }
}
