using System;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

class PlayWithIntDoubleString
{
    private static int menuChoice = 0;
    private static int intVar;
    private static double doubleVar;
    private static string stringVar;

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        ChooseVariable();
        ReadVariable();
        PrintVariable();
    }

    static void ChooseVariable()
    {
        while(menuChoice < 1 || menuChoice > 3)
        {
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            Console.Write("Enter your choice: ");

            int.TryParse(Console.ReadLine(), out menuChoice);
        }
    }

    static void ReadVariable()
    {
        switch(menuChoice)
        {
            case 1:
                Console.Write("Enter an int: ");
                int.TryParse(Console.ReadLine(), out intVar);
                intVar += 1;
                break;
            case 2:
                Console.Write("Enter a double: ");
                double.TryParse(Console.ReadLine(), out doubleVar);
                doubleVar += 1d;
                break;
            case 3:
                Console.Write("Enter a string: ");
                stringVar = Console.ReadLine();
                stringVar += "*";
                break;
        }
    }

    static void PrintVariable()
    {
        switch (menuChoice)
        {
            case 1:
                Console.WriteLine(intVar);
                break;
            case 2:
                Console.WriteLine(doubleVar);
                break;
            case 3:
                Console.WriteLine(stringVar);
                break;
        }
    }
}
