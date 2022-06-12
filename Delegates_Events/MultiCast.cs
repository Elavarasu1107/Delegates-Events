using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public class MultiCast
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            DelOp obj = operations.Add;
            obj += operations.Square;

            obj(5, 5);
            obj(6, 5);
        }
        public class operations
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition = {0}", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiplication = {0}", a * b);
            }
        }
    }
}
