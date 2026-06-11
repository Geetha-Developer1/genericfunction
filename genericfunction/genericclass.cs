using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericfunction
{
    class myclass<t>
    {
        t a;
        public myclass(t a)
        {
            this.a = a;
        }
        public void Display()
        {
            Console.WriteLine("Value of a is :" + a);
        }

    }
    internal class genericclass
    {
        //static void Main(string[] args)
        //{
        //    myclass<int> obj = new myclass<int>(100);
        //    obj.Display();
        //    myclass<string> objst = new myclass<string>("abc");
        //    objst.Display();
        //}
    }
}
