using System;

class Program
{
    static void Main()
    {
        int sides = int.Parse(Console.ReadLine());
        int xAddition = 0, xOffset = 0;
        for (int i = 0; i < sides + xAddition; i++)
        {
            if (i >= sides)
            {
                xOffset++;
            }

            for (int j = 0; j < sides + xAddition; j++)
            {
                if (xOffset == 0)
                {
                    if (i == 0 || j == 0 || j >= sides - 1 || i == sides - 1)
                    {
                        if (j >= sides && j < sides + xAddition - 1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(":");
                        }
                    }
                    else if (j > 0 && j < sides)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    if (xOffset == j || i == sides + xAddition - 1 && j >= xOffset || j >= sides + xOffset - 1)
                    {
                        if (j >= sides + xOffset && j < sides + xAddition - 1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(":");
                        }
                    }
                    else if(j < xOffset)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
            xAddition = xAddition + 1 > sides - 1 ? xAddition : xAddition + 1;
            Console.WriteLine();
        }
    }
}
