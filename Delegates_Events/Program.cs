using System;

namespace Delegates_Events
{
    public delegate int Operations(int x, int y);
    public delegate void DelEventHandler();
    public class Program
    {
        public static event DelEventHandler add;
        static int Addition(int a, int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("--------DelegatesDemo------");
            Operations obj = new Operations(Addition);
            Console.WriteLine("Addition = {0}", obj(23, 27));

            ArrayDelegates.ImplementDelegate();
            MultiCast.ImplementDelegate();

            Console.WriteLine("--------EventsDemo------");
            add += new DelEventHandler(India);
            add += new DelEventHandler(USA);
            add += new DelEventHandler(England);
            add.Invoke();
            Console.WriteLine("-----Event Handling-----");
            EventHandling.ImplementEvent();
        }
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
        public static void England()
        {
            Console.WriteLine("England");
        }
    }
}
