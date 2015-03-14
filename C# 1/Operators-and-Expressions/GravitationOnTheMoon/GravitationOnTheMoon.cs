using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            MassOnMoon(86);
            MassOnMoon(74.6f);
            MassOnMoon(53.7f);
        }

        static void MassOnMoon(float mass)
        {
            Console.WriteLine(mass + ": " + mass * 0.17f);
        }
    }
}
