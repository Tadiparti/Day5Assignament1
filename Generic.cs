using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignament1
{
    internal class Generic
    {
        static void Swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 50, b = 38;
            Console.WriteLine("Before swap:{0},{1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap:{0},{1}", a, b);
            Console.ReadLine();
        }
    }
}
