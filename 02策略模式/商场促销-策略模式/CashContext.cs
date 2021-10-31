using System;
using System.Collections.Generic;
using System.Text;

namespace _02策略模式.商场促销_策略模式
{
    internal class CashContext
    {
        private readonly CashSuper _cs;
        public CashContext(CashSuper cashSuper)
        {
            this._cs = cashSuper;
        }

        public double GetResult(double money)
        {
            return _cs.AcceptCash(money);
        }
    }
}
