using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _11抽象工厂
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "11抽象工厂";
        private static readonly string db = "SqlServer";
        //private static readonly string db = "Access";

        public static IUser CreateUser()
        {
            string className = $"_11抽象工厂.{db}User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = $"_11抽象工厂.{db}Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }


    }
}
