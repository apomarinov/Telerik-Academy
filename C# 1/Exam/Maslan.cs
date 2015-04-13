using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        int numberOfTransformations = 0;

        while (number > 10)
        {
            numberOfTransformations++;
            number = Transform(number);
            if (numberOfTransformations == 10)
            {
                break;
            }
        }

        if (numberOfTransformations < 10)
        {
            Console.WriteLine(numberOfTransformations);
        }
        Console.WriteLine(number);
    }

    static BigInteger Transform(BigInteger num)
    {
        BigInteger sumProduct = 1;
        BigInteger nextSum;

        while (Convert.ToString(num).Length > 1)
        {
            num = num / 10;
            nextSum = OddDigitSum(num);
            sumProduct *= nextSum == 0 ? 1 : nextSum;
        }

        return sumProduct;
    }

    static BigInteger OddDigitSum(BigInteger num)
    {
        string numAsStr = num.ToString();
        BigInteger sum = 0;

        for (int i = 0; i < numAsStr.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += BigInteger.Parse(numAsStr[i].ToString());
            }
        }

        return sum;
    }
}