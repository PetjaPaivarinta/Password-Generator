using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Random num = new Random();

            string[] chars = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            Console.WriteLine("Welcome to the Password Generator");

            Console.WriteLine("Press Enter to start");
            Console.WriteLine();

            while (1 > 0)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {

                    for (int i = 0; i < 20; i++)
                    {
                        int random = num.Next(0, 30);
                        if (i % 4 == 0)
                        {
                            Console.Write(chars[random].ToUpper());
                        }
                        else
                            Console.Write(chars[random]);
                        if (i == 19)
                        {
                            Console.WriteLine();
                            Console.WriteLine("\nPress any key to generate a new password");
                            Console.WriteLine();
                        }
                    }
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        }
    }
