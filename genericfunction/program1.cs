using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericfunction
{
    class calculate
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    internal delegate int mydelegate(int x, int y);
    internal class program1
    {
        //static void Main(string[] args)
        //{
        //    calculate c = new calculate();
        //    mydelegate del = new mydelegate(c.add);
        //    Console.WriteLine(del);
        //    int res = del(100, 2000);
        //    Console.WriteLine(res);
        //}
    }
}
