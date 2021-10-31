namespace _10观察者模式.notice
{
    public abstract class Observer
    {
        protected string name;
        protected ISubject sub;
        public Observer(string name,ISubject sub)
        {
            this.name = name;
            this.sub = sub;  
        }

        public abstract void Update();
    }

    class StockObserver : Observer
    {
        public StockObserver(string name, ISubject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            System.Console.WriteLine($"{sub.SubjectState}  {name} 关闭股票，工作！！！");
        }
    }

    class NBAObserver : Observer
    {
        public NBAObserver(string name, ISubject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            System.Console.WriteLine($"{sub.SubjectState}  {name} 关闭NBA，工作！！！");
        }
    }
}