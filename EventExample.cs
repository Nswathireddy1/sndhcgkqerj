using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    public delegate void mydelegate1(int x, int y);//one delegate
    class EventExample
    {
        public static event mydelegate1 event1;//two events
        public static event mydelegate1 event2;
        public static void M1(int x,int y)
        {
            Console.WriteLine("i am M1");
        }
        public static void M2(int x, int y)
        {
            Console.WriteLine("i am M2");
        }
        static void Main(string[] args)
        {
            event1 += new mydelegate1(M1);
            event2 += new mydelegate1(M2);
            event1(10, 20);
            Console.Read();
        }
    }
}
