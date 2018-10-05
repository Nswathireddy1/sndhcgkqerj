using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    class ClsDelegates
    {
        static void Display(string s) //method creation.
        {
            Console.WriteLine("value of s is:" + s); //this is reference purpose here refer one value at a time
        }
        delegate void mydelegate(string a); //creation of delegate.actually we r use acces modifier also but this is single class
        static void Main(string[] args)
        {
             mydelegate obj1 = new mydelegate(Display); //object creation and read target value(which value u required)
            obj1("hello");//object name and passing values. invoking
            Console.Read();
        }
    }
}
