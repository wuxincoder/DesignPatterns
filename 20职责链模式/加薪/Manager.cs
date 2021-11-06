using System;
using System.Collections.Generic;
using System.Text;

namespace _20职责链模式.加薪
{
    public abstract class Manager
    {
        protected string _name;

        protected Manager _superior;

        public Manager(string name)
        {
            this._name = name;
        }

        public void SetSuperior(Manager superior)
        {
            _superior = superior;
        }

        abstract public void RequestApplications(Request request);

        public void GetResult(string managerLevel, Request request)
        {
            if (managerLevel == "经理")
            {
                if (request.RequestType == "请假" && request.Number <= 2)
                {
                    Console.WriteLine(
                        $"{_name}:{request.RequestContent} 数量 {request.Number} 被批准");
                }
                else
                {
                    Console.WriteLine(
                        $"{_name}:{request.RequestContent} 数量 {request.Number} 我无权处理");

                }
            }
            else if (managerLevel == "总监")
            {
                if (request.RequestType == "请假" && request.Number <= 5)
                {
                    Console.WriteLine(
                        $"{_name}:{request.RequestContent} 数量 {request.Number} 被批准");
                }
                else
                {
                    Console.WriteLine(
                        $"{_name}:{request.RequestContent} 数量 {request.Number} 我无权处理");

                }
            }
            else if (managerLevel == "总经理")
            {
                if (request.RequestType == "请假")
                {
                    Console.WriteLine(
                        $"{_name}:{request.RequestContent} 数量 {request.Number} 被批准");
                }
                else if (request.RequestType == "加薪" && request.Number <= 500)
                {
                    Console.WriteLine(
                        $"{_name}:{request.RequestContent} 数量 {request.Number} 被批准");
                }
                else if (request.RequestType == "加薪" && request.Number >500)
                {
                    Console.WriteLine(
                        $"{_name}:{request.RequestContent} 数量 {request.Number} 再说吧");
                }
                else
                {
                    Console.WriteLine(
                        $"{_name}:{request.RequestContent} 数量 {request.Number} 我无权处理");

                }
            }
        }
    }

    public class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 2)
            {
                Console.WriteLine(
                    $"{_name}:{request.RequestContent} 数量 {request.Number} 被批准");
            }
            else if (_superior != null)
            {
                _superior.RequestApplications(request);
            }

        }
    }

    public class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 5)
            {
                Console.WriteLine(
                    $"{_name}:{request.RequestContent} 数量 {request.Number} 被批准");
            }
            else if (_superior != null)
            {
                _superior.RequestApplications(request);
            }
        }
    }

    public class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine(
                    $"{_name}:{request.RequestContent} 数量 {request.Number} 被批准");
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine(
                    $"{_name}:{request.RequestContent} 数量 {request.Number} 被批准");
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine(
                    $"{_name}:{request.RequestContent} 数量 {request.Number} 再说吧");
            }
            
        }
    }

}
