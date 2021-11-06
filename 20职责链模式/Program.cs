using _20职责链模式.加薪;
using _20职责链模式.职责链;
using System;

namespace _20职责链模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager manager1 = new Manager("管理者1");
            //Manager manager2 = new Manager("管理者2");
            //Manager manager3 = new Manager("管理者3");
            //Request request = new Request();
            //request.RequestType = "加薪";
            //request.RequestContent = "小菜请求加薪";
            //request.Number = 1000;
            //manager1.GetResult("经理", request);
            //manager2.GetResult("总监", request);
            //manager3.GetResult("总尽力", request);
            //Request request2 = new Request();
            //request2.RequestType = "请假";
            //request2.RequestContent = "小菜请假";
            //request2.Number = 3;
            //manager1.GetResult("经理", request2);
            //manager2.GetResult("总监", request2);
            //manager3.GetResult("总尽力", request2);

            //Handler handler1 = new ConcreteHandler1();
            //Handler handler2 = new ConcreteHandler2();
            //Handler handler3 = new ConcreteHandler3();
            //handler1.SetSuccessor(handler2);
            //handler2.SetSuccessor(handler3);
            //int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
            //foreach (var item in requests)
            //{
            //    handler1.HandleRequest(item);
            //}

            CommonManager commonManager = new CommonManager("经理");
            Majordomo majordomo = new Majordomo("总监");
            GeneralManager generalManager = new GeneralManager("总经理");
            commonManager.SetSuperior(majordomo);
            majordomo.SetSuperior(generalManager);
            Request request = new Request();
            request.RequestType = "加薪";
            request.RequestContent = "小菜请求加薪";
            request.Number = 1000;
            commonManager.RequestApplications(request);
            request = new Request();
            request.RequestType = "加薪";
            request.RequestContent = "小菜请求加薪";
            request.Number = 300;
            commonManager.RequestApplications(request);
            request = new Request();
            request.RequestType = "请假";
            request.RequestContent = "小菜请假";
            request.Number = 1;
            commonManager.RequestApplications(request);
            request = new Request();
            request.RequestType = "请假";
            request.RequestContent = "小菜请假";
            request.Number = 5;
            commonManager.RequestApplications(request);
        }
    }
}
