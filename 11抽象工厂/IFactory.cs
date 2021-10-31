using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    public interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }

    public class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }

    public class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

    }
}
