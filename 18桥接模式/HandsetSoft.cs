﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _18桥接模式
{
    public abstract class HandsetSoft
    {
        public abstract void Run();
    }

    public class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }

    public class HandsetAddressList : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机通讯录");
        }
    }


}
