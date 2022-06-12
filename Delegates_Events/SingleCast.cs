using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public class Operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition = {0}", a + b);
        }
        public static void Multiple(int a, int b)
        {
            Console.WriteLine("Multiplication = {0}", a * b);
        }
    }
    class ArrayDelegates
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            DelOp[] obj = {new DelOp(Operation.Add), new DelOp(Operation.Multiple) };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] (5, 5);
                obj[i] (6, 5);
                obj[i] (6, 8);
                Console.WriteLine();
            }
        
        }
    }
}
