using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericfunction
{
    class example<t,k>
    {
        
        public void Display(t pw,k cpw)
        {
            Console.WriteLine("Password :" + pw);
            Console.WriteLine("Confirm password :" + cpw);
        }
    }
    internal class genericclassExample
    {
        static void Main(string[] args)
        {
            example<int,string> obj = new example<int, string>();
            obj.Display(100, "abc");
        }
    }
}
