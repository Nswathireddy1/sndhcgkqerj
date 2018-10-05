using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMetod
    {
        static void Main(string[] args)
        {
            GreetingsDelegate obj1 = delegate(string name)
            {
                return "hello" + name + "good morning";
            };
        string str = obj1.Invoke("swathi");
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
