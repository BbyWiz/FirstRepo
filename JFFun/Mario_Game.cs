using System;
using System.Windows;
class Program
{
    static void Main()
    {
        Console.WindowHeight = 20;
        Console.WindowWidth = 40;
        int floorHeight = 18;
        int marioPosition = 10;

        while (true)
        {
            Console.Clear();

            // Draw the ground
            for (int i = 0; i < floorHeight; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("####################");

            // Draw Mario
            for (int i = 0; i < marioPosition; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("M");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                // Move Mario to the left
                if (marioPosition > 0)
                {
                    marioPosition--;
                }
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                // Move Mario to the right
                if (marioPosition < Console.WindowWidth - 2)
                {
                    marioPosition++;
                }
            }
        }
        class Windows{
        Console.WindowHeight = 20;
        Console.WindowWidth = 40;
        Console.BufferHeight = 20;
        Console.BufferWidth = 40;

        int floorHeight = 18;
        int marioPosition = 10;

        while (true)
        {
            Console.Clear();

            // Draw the ground
            for (int i = 0; i < floorHeight; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("####################");

            // Draw Mario
            for (int i = 0; i < marioPosition; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("M");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                // Move Mario to the left
                if (marioPosition > 0)
                {
                    marioPosition--;
                }
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                // Move Mario to the right
                if (marioPosition < Console.WindowWidth - 2)
                {
                    marioPosition++;
                }
            }

