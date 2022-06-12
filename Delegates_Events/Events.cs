using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public delegate void EventHandler(string x);
    class EventHandling
    {
        public class Operation
        {
            public event EventHandler xyz;
            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImplementEvent()
        {
            Operation operation = new Operation();
            operation.Action("Event Calling");
            Console.WriteLine();
            operation.xyz += new EventHandler(CatchEvent);
            operation.Action("Event Called");
        }
    }
}
    
