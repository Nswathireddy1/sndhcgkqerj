using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    class LambdaExpression
    {
        static void Main(string[] args)
        {
            GreetingsDelegate obj = name =>
              {
                  return " hello " + name + " good morning ";
              };
            string str = obj.Invoke(" dad ");
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
