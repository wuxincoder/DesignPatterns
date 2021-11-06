using System;

namespace _18桥接模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //手机品牌
            HandsetBrand ab;
            ab = new HandsetBrandM();
            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();
            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();
            ab = new HandsetBrandN();
            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();
            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();


        }
    }
}
