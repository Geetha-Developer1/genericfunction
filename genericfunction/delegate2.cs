using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericfunction
{
    class login
    {
      public string check(string un, string pw)
        {
            if (un == "abc" && pw == "abc123")
            {
                return "Login Successfully";
            }
            else
                return "Invalid";
        }

    }
    internal delegate string details(string un, string pw);
    internal class delegate2
    {
      static void Main(string[] args)
        {
            login l = new login();
            details delobj = new details(l.check);
            string val = delobj("abc", "abc123");
            Console.WriteLine(val);

        }
    }
}
