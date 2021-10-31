using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    public interface IDepartment
    {
        void Insert(Department department);
        Department Get(int id);
    }

    public class SqlServerDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在SQL Server中给Department表添加一条记录");
        }
        public Department Get(int id)
        {
            Console.WriteLine("在SQL Server 中根据 id 获取 Department 表一条记录");

            return null;
        }

    }

    public class AccessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在 Access 中给Department表添加一条记录");
        }
        public Department Get(int id)
        {
            Console.WriteLine("在 Access 中根据 id 获取 Department 表一条记录");

            return null;
        }

    }
}
