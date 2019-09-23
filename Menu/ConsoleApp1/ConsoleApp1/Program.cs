using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Char Selection = ' ';
            Menu();
            
            Console.ForegroundColor = ConsoleColor.Black;

            Selection = Console.ReadKey().KeyChar;

            Music();

            switch (Selection)
            {
                case '1':

                    break;
                case '2':
                    Option();
                    break;
                case '3':

                    break;
                case '4':

                    break;
                case '5':
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }
        }

        static void Menu()
        {
            Console.WriteLine();

            Console.Write("{0,52:D}{1,52:D}{2,52:D}{3,52:D}{4,57:D}{5,56:D}", "███████╗████████╗███╗   ███╗██╗\n", "██╔════╝╚══██╔══╝████╗ ████║██║\n", "█████╗     ██║   ██╔████╔██║██║\n", "██╔══╝     ██║   ██║╚██╔╝██║██║\n", "███████╗   ██║   ██║ ╚═╝ ██║███████╗\n", "╚══════╝   ╚═╝   ╚═╝     ╚═╝╚══════╝");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n{0, 39:D}", "1 : Jouer");
            Console.WriteLine("\n\n{0, 41:D}", "2 : Options");
            Console.WriteLine("\n\n{0, 43:D}", "3 : HighScore");
            Console.WriteLine("\n\n{0, 42:D}", "4 : A Propos");
            Console.WriteLine("\n\n{0, 41:D}", "5 : Quitter");
        }

        static void Jouer()
        {

        }

        static void Option()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 : Music (ON / OFF) : ");
            Console.WriteLine("2 : Difficulté (Padawan / Jedi : ");
            Console.ReadLine();
        }

        static void HighScore()
        {

        }

        static void Propos()
        {
        }
        static void Music()
        {

            /*
                        Console.Beep(1320, 500);
                        Console.Beep(990, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 250);
                        Console.Beep(1320, 125);
                        Console.Beep(1188, 125);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 250);
                        Console.Beep(880, 500);
                        Console.Beep(880, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1320, 500);
                        Console.Beep(1188, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 750);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 500);
                        Console.Beep(1320, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(880, 500);
                        Console.Beep(880, 500);

                        Thread.Sleep(250);

                        Console.Beep(1188, 500);
                        Console.Beep(1408, 250);
                        Console.Beep(1760, 500);
                        Console.Beep(1584, 250);
                        Console.Beep(1408, 250);
                        Console.Beep(1320, 750);
                        Console.Beep(1056, 250);
                        Console.Beep(1320, 500);
                        Console.Beep(1188, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 500);
                        Console.Beep(990, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 500);
                        Console.Beep(1320, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(880, 500);
                        Console.Beep(880, 500);
                        Thread.Sleep(500);
                        */
        }

    }

}
