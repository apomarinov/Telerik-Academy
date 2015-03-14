using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string h = "hello",
                   w = "world";
            object o = h + " " + w;
            string os = (string)o;

            Console.WriteLine(os);
        }
    }
}
