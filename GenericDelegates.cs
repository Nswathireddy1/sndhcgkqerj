using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    public delegate double Delegates1(int x, float y, double z);//func
    public delegate void Delegates2(int x, float y, double z);//action
    public delegate bool Delegates3(int x, int y, int z);//predicate
    class GenericDelegates
    {
        public static double AddNums1(int x,float y,double z)
        {
            return x + y + z;
        }
        public static void  AddNums2(int x, float y, double z)
        {
            Console.WriteLine( x + y + z);
        }
        public static bool checkLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = AddNums1;
            double result = obj1.Invoke(100, 34.5f, 198.67);
            Console.WriteLine(result);
            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(100, 34.5f, 198.67);
            Predicate<string> obj3 = checkLength;
            bool starts = obj3.Invoke("hello world");
            Console.WriteLine(starts);
            Console.ReadLine();
        }

    }
}
