using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    class Delegate1
    {
        public void display(string s)
        {
            Console.WriteLine("value of s is:" + s);
        }
    }
        public delegate void sampledelegate(string s);
        class Delegate2
        {
            static void Main(string[] args)
            {
            Delegate1 obj1 = new Delegate1();
            sampledelegate objd = new sampledelegate(obj1.display);
            objd("welcome");
            Console.Read();
            }

        }
}// this also same as the above but here we r using 2 classes that's y using public(acces modifier). 

