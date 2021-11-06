using System;
using System.Collections.Generic;
using System.Text;

namespace _18桥接模式
{
    public abstract class HandsetBrand
    {
        protected HandsetSoft soft;

        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }

        public abstract void Run();
    }

    public class HandsetBrandN:HandsetBrand
    {
        public override void Run()
        {
            soft.Run();
        }
    }

    public class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            soft.Run();
        }
    }
}
