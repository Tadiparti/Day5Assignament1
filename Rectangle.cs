using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignament1
{
    class Rectangle
    {
        public double Width;
        public double length;

        public double GetArea()
        {
            return length * Width;
        }
        public void display()
        {
            Console.WriteLine("Width:{0}", Width);
            Console.WriteLine("Length:{0}", length);
            Console.WriteLine("Area:{0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle()    ;
            rect.Width = 8.5;
            rect.length = 6;
            rect.display();
            Console.ReadLine();
        }
    }
}
