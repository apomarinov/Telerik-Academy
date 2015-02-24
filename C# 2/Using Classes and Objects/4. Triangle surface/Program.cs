using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

class Program
{
    static int menuChoice = -1;
    static double a, b, c;
    static double heightA;
    static double angleA;

    public static void Main()
    {
        while (true)
        {
            if (!ReadInput())
            {
                Console.WriteLine("Invalid Input bro");
                return;
            }

            SolveTask();

            if (Quit())
            {
                return;
            }
        }
    }

    static bool ReadInput()
    {
        GetUserChoice();

        switch (menuChoice)
        {
            case 1:
                Console.Write("Enter side: ");
                if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    return false;
                }
                Console.Write("Enter height to the side: ");
                if (!double.TryParse(Console.ReadLine(), out heightA) || heightA <= 0)
                {
                    return false;
                }
                break;
            case 2:
                Console.Write("Enter side a: ");
                if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    return false;
                }
                Console.Write("Enter side b: ");
                if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    return false;
                }
                Console.Write("Enter side c: ");
                if (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    return false;
                }
                break;
            case 3:
                Console.Write("Enter side a: ");
                if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    return false;
                }
                Console.Write("Enter side b: ");
                if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    return false;
                }
                Console.Write("Enter angle between the sides: ");
                if (!double.TryParse(Console.ReadLine(), out angleA) || angleA <= 0)
                {
                    return false;
                }
                break;
        }

        return true;
    }

    static void GetUserChoice()
    {
        bool validChoice = false;

        while (!validChoice)
        {
            PrintMenu();
            validChoice = int.TryParse(Console.ReadLine(), out menuChoice) && menuChoice >= 1 && menuChoice <= 3;
        }
    }

    static void PrintMenu()
    {
        Console.WriteLine("\nFind triangle area by:");
        Console.WriteLine("1. Side and an altitude to it.");
        Console.WriteLine("2. Three sides.");
        Console.WriteLine("3. Two sides and an angle between them.");
    }

    static void SolveTask()
    {
        switch (menuChoice)
        {
            case 1:
                Console.WriteLine("Area by side and height to it: " + AreaBySideAndHeight(a, heightA).ToString("F2"));
                break;
            case 2:
                Console.WriteLine("Area by three sides: " + AreaByThreeSides(a, b, c).ToString("F2"));
                break;
            case 3:
                Console.WriteLine("Area by two sides and angle between them: " + AreaByTwoSidesAndAngle(a, b, angleA).ToString("F2"));
                break;
        }
    }

    static double AreaBySideAndHeight(double side, double height)
    {
        return (side * height) / 2d;
    }

    static double AreaByThreeSides(double a, double b, double c)
    {
        double halfPeremeter = (a + b + c) / 2;
        return Math.Sqrt(halfPeremeter * (halfPeremeter - a) * (halfPeremeter - b) * (halfPeremeter - c));
    }

    static double AreaByTwoSidesAndAngle(double a, double b, double angAB)
    {
        return 0.5 * a * b * Math.Sin(Math.PI * 48 / 180.0);
    }

    static bool Quit()
    {
        Console.Write("\nAgain? y/n: ");
        return Console.ReadLine() == "n";
    }
}