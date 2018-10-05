using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExample
{
    public delegate void LinktoEventhandler();//delegate creation
    class Master
    {
        public string name;
        public Master(string argname)
        {
            name = argname;
        }
        public void EventHandler()
        {
            Console.WriteLine("notification from {0}", name);
        }
    }
    class program
    {
        public static event LinktoEventhandler evt; //event creation
        public static void Sendnotification()
        {
            if(evt!=null)
            {
                evt();
            }
        }
        static void Main(string[] args)
        {
            Master m1 = new Master("object of master");
            evt += new LinktoEventhandler(m1.EventHandler);
            Master m2 = new Master("object of master");
            evt += new LinktoEventhandler(m2.EventHandler);
            Master m3 = new Master("object of master");
            evt += new LinktoEventhandler(m3.EventHandler);
            Master m4 = new Master("object of master");
            evt += new LinktoEventhandler(m4.EventHandler);
            Master m5 = new Master("object of master");
            evt += new LinktoEventhandler(m5.EventHandler);
            Sendnotification();
            Console.ReadLine();
        }
    }
}
