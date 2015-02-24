using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        long num;
        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                sb.Append("000000000000000000000000000000");
            }
            else
            {
                sb.Append(Convert.ToString(num, 2).PadLeft(30, '0'));
            }
            
        }

        string bits = sb.ToString();
        int zeroSum = 0, oneSum = 0, zeros = 0, ones = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i] == '0')
            {
                zeroSum++;
                if (oneSum > 0)
                {
                    
                    if (ones < oneSum)
                    {
                        ones = oneSum;
                    }
                    oneSum = 0;
                }
            }
            else if (bits[i] == '1')
            {
                oneSum++;
                if (zeroSum > 0)
                {
                    if (zeros < zeroSum)
                    {
                        zeros = zeroSum;
                    }
                    zeroSum = 0;
                }
            }
        }
        if (zeros < zeroSum)
        {
            zeros = zeroSum;
        }

        if (ones < oneSum)
        {
            ones = oneSum;
        }
        Console.WriteLine(ones);
        Console.WriteLine(zeros);
    }
}
