using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            IsPrime(1);
            IsPrime(2);
            IsPrime(3);
            IsPrime(4);
            IsPrime(9);
            IsPrime(97);
            IsPrime(51);
            IsPrime(-3);
            IsPrime(0);
        }

        static void IsPrime(int num)
        {
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine("Is number " + num + " prime: " + isPrime);
        }
    }
}
