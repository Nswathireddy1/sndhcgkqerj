using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    class ClsDelegate1
    {
        static void Display(string s)
        {
            Console.WriteLine("value of s is:" + s);
        }
        static void Display(int x, int y)
        {
            Console.WriteLine("addition is:" + (x + y));
        }
        delegate void mydelegate(string a);
        delegate void mydelegate1(int x, int y);
        static void Main(string[] args)
        {
            mydelegate obj1 = new mydelegate(Display);
            mydelegate1 obj2 = new mydelegate1(Display);
            obj1("swathi");
            obj2(10, 40);
            Console.Read();
        }
    }
}
