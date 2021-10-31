using System;
using System.Collections.Generic;
using System.Text;

namespace _05工厂方法模式.工厂方法模式_学雷锋
{
    public interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }

    public class UndergraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }
    public class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
