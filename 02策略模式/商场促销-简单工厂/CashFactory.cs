using System;
using System.Collections.Generic;
using System.Text;

namespace _02策略模式.商场促销_简单工厂
{
    internal class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cashSuper = null;
            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "满300返100":
                    cashSuper = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cashSuper = new CashRebate("0.8");
                    break;
            }
            return cashSuper;
        }
    }
}
