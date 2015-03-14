using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes_in_Strings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string escSeq = "The \"use\" of quotations causes difficulties.",
                   strliteral = @"The ""use"" of quotations causes difficulties."; ;

            Console.WriteLine("With escape characters: " + escSeq);
            Console.WriteLine("With string literal: " + strliteral);
        }
    }
}
