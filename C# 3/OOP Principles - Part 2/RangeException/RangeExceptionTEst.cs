using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RangeException;

class RangeExceptionTEst
{
    static void Main(string[] args)
    {
        try
        {
            throw new InvalidRangeException<int>("Invalid number range!", 5, 10);
        }
        catch (InvalidRangeException<int> e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            throw new InvalidRangeException<DateTime>("Invalid date range!", new DateTime(1981, 1, 1), new DateTime(2013, 12, 31));
        }
        catch (InvalidRangeException<DateTime> e)
        {
            Console.WriteLine(e.Message);
        }
    }
}