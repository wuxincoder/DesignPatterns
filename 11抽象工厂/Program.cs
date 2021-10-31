using System;

namespace _11抽象工厂
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department department = new Department();
            //IFactory factory = new SqlServerFactory();
            //IFactory factory = new AccessFactory();

            IUser user1 = DataAccess.CreateUser();
            user1.Insert(user);
            user1.Get(1);

            IDepartment department1 = DataAccess.CreateDepartment();
            department1.Insert(department);
            department1.Get(1);

        }
    }
}
