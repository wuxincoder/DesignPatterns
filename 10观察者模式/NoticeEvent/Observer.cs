namespace _10观察者模式
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

    class StockObserver 
    {
        private string name;
        private ISubject sub;
        public StockObserver(string name, ISubject sub) 
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStock()
        {
            System.Console.WriteLine($"{sub.SubjectState}  {name} 关闭股票，工作！！！");
        }
    }

    class NBAObserver 
    {
        private string name;
        private ISubject sub;


        public NBAObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNBA()
        {
            System.Console.WriteLine($"{sub.SubjectState}  {name} 关闭NBA，工作！！！");
        }
    }
}