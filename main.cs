/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static int a = 1, b = 100;
        
        static int overall = 0;
        
        static int least, most;
        static int tries = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:\n\t1. Start the game\n\t2. Change the range\n\t3. Statistics\n\t4. Exit");
                int user_menu_input = int.Parse(Console.ReadLine());
                switch (user_menu_input)
                {
                    case 1:
                        MainGame();
                        break;
                    case 2:
                        RangeChange();
                        break;
                    case 3:
                        Console.WriteLine($"Games played: {overall}\nLeast attempts: {least}\nMost attempts: {most}");
                        break;
                    case 4:
                        return;
                    default:
                        break;
    
                }
                Statistics();
            }

        }

        static void MainGame()
        {
            tries = 0;
            int number = new Random().Next(a, b+1);

            int user_number = 0;

            while (user_number != number)
            {

                while (!int.TryParse(Console.ReadLine(), out user_number) || user_number < a || user_number > b+1)
                {
                    Console.WriteLine("Why are you a dumbass?");
                }
                if (user_number > number)
                {
                    Console.WriteLine("Smaller");
                }
                else if (user_number < number)
                {
                    Console.WriteLine("Bigger");
                }
            tries++;
            }
            overall++;
        }
        
        static void RangeChange()
        {
            while (true)
            {
                Console.Write("Type value of a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Type value of b: ");
                b = int.Parse(Console.ReadLine());
                if (a >= b) Console.WriteLine("a is bigger than b. Please type again.");
                else 
                {
                    Console.WriteLine($"The range is now ({a}, {b})");
                    break;
                }
            }
        }
        
        static void Statistics()
        {
            if (overall < 2)
            {
                least = tries;
                most = tries;
            }
            else
            {
                if (tries > most) most = tries;
                else if (tries < least) least = tries;
            }
        }
    }
}
