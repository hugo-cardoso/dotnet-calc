using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("== MENU ==");
            Console.WriteLine("");

            Console.WriteLine("1 - SUM");
            Console.WriteLine("2 - SUBTRACT");
            Console.WriteLine("3 - DIVIDER");
            Console.WriteLine("4 - MULTIPLY");
            Console.WriteLine("5 - EXIT");

            switch (ReadInputNumber("Select a option:"))
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Divider();
                    break;
                case 4:
                    Multiply();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }
        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("== SUM ==");
            Console.WriteLine("");

            float valueOne = ReadInputNumber("First Value:");
            float valueTwo = ReadInputNumber("Second Value:");

            Console.WriteLine("");

            Console.WriteLine($"The result is: { valueOne + valueTwo }");
            Finish();
        }
        static void Subtract()
        {
            Console.Clear();

            Console.WriteLine("== SUBTRACT ==");
            Console.WriteLine("");

            float valueOne = ReadInputNumber("First Value:");
            float valueTwo = ReadInputNumber("Second Value:");

            Console.WriteLine("");

            Console.WriteLine($"The result is: { valueOne - valueTwo }");
            Finish();
        }
        static void Divider()
        {
            Console.Clear();

            Console.WriteLine("== DIVIDER ==");
            Console.WriteLine("");

            float valueOne = ReadInputNumber("First Value:");
            float valueTwo = ReadInputNumber("Second Value:");

            Console.WriteLine("");

            Console.WriteLine($"The result is: { valueOne / valueTwo }");
            Finish();
        }
        static void Multiply()
        {
            Console.Clear();

            Console.WriteLine("== MULTIPLY ==");
            Console.WriteLine("");

            float valueOne = ReadInputNumber("First Value:");
            float valueTwo = ReadInputNumber("Second Value:");

            Console.WriteLine("");

            Console.WriteLine($"The result is: { valueOne * valueTwo }");
            Finish();
        }
        static float ReadInputNumber(string label)
        {
            Console.WriteLine(label);
            return float.Parse(Console.ReadLine());
        }
        static void Finish()
        {
            Console.WriteLine("Press any key to finish.");
            Console.ReadKey();
            Menu();
        }
    }
}
