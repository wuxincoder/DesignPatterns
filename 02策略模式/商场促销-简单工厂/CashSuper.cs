using System;
using System.Collections.Generic;
using System.Text;

namespace _02策略模式
{
    abstract class CashSuper
    {
        //现金收取抽象类的抽象方法，收取现金，参数为原价，返回为当前价
        public abstract double AcceptCash(double money);
    }

    class CashNormal : CashSuper
    {
        //正常收费 ，原价返回
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
    class CashRebate : CashSuper
    {
        private readonly double _moneyRebate = 1d;
        //打折收费，初始化时，必需要输入折扣率，如八折，就是0.8
        public CashRebate(string moneyRebate)
        {
            this._moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * _moneyRebate;
        }
    }

    class CashReturn : CashSuper
    {
        private readonly double _moneyCondition = 0.0d;
        private readonly double _moneyReturn = 0.0d;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this._moneyCondition = double.Parse(moneyCondition);
            this._moneyReturn = double.Parse(moneyReturn);
        }


        public override double AcceptCash(double money)
        {
            //大于返利条件，每满_moneyCondition减_moneyReturn
            double result = money;
            if (money >= _moneyCondition)
                result = money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            return result;
        }
    }

}
