using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    class ClsDelegate5
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine("area is:" + width * height);
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter is:" + 2 * (width + height));
        }
        public delegate void RectDelegate(double width, double height);
        static void Main(string[] args)
        {
            ClsDelegate5 obj1= new ClsDelegate5();
            RectDelegate obj2 = new RectDelegate(obj1.GetArea);
            obj2 += obj1.GetPerimeter;
            obj2(12.34, 56.78);
            Console.WriteLine();
            obj2(17.13, 45.87);
            Console.Read();
        }
    }
}
