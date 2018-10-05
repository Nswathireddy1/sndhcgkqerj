using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    class ClsDelegate3
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("addition is:" + (a + b));
        }
        public void Sub(int a,int b)
        {
            Console.WriteLine("diffrence is:" + (a - b));
        }
        public void Mul(int a,int b)
        {
            Console.WriteLine("product is:" + (a * b));
        }
        public void Div(int a,int b)
        {
            Console.WriteLine("quotient is:" + (a / b));
        }
    }
    public delegate void McDelegate(int a, int b);
    class ClsMulticast
    {
        static void Main(string[] args)
        {
            ClsDelegate3 obj1 = new ClsDelegate3();
            McDelegate objd = new McDelegate(obj1.Add);
            objd += obj1.Sub;
            objd += obj1.Mul;
            objd += obj1.Div;
            objd(20, 30);
            Console.Read();
        }
    }
}
