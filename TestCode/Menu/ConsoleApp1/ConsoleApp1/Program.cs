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
            // appelle des méthodes
            Music(true);                    // lance une musique
            Menu();                     // affiche le menu
        }

        static void Etml()
        {
            // change la couleur d'écriture
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.SetCursorPosition(18, 1);
            Console.WriteLine("███████╗████████╗███╗   ███╗██╗");
            Console.SetCursorPosition(18, 2);
            Console.WriteLine("██╔════╝╚══██╔══╝████╗ ████║██║");
            Console.SetCursorPosition(18, 3);
            Console.WriteLine("█████╗     ██║   ██╔████╔██║██║");
            Console.SetCursorPosition(18, 4);
            Console.WriteLine("██╔══╝     ██║   ██║╚██╔╝██║██║");
            Console.SetCursorPosition(18, 5);
            Console.WriteLine("███████╗   ██║   ██║ ╚═╝ ██║███████╗");
            Console.SetCursorPosition(18, 6);
            Console.WriteLine("╚══════╝   ╚═╝   ╚═╝     ╚═╝╚══════╝");
        }

        static void Menu()
        {
            // variables 
            Char Selection = ' ';       // sert a selectionner le bon menu
            Console.Clear();
            Etml();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("1 : Jouer");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("2 : Options");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("3 : HighScore");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("4 : A Propos");
            Console.SetCursorPosition(30, 21);
            Console.WriteLine("5 : Quitter");

            // tant que l'utilisateur n'a pas entrer une valeur entre 1 et 5 recommence
            do
            {
                Selection = Console.ReadKey(true).KeyChar;
            }
            while (Selection < '1' || Selection > '5');

            // selectionne la bonne méthode
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

        static void Jouer()
        {

        }

        static void Option()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Etml();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("1 : Music (ON) : ");
            Music(true);
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("1 : Music (OFF) : ");
            Music(false);
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("2 : Difficulté (Padawan / Jedi : ");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("3 : Retour au Menu");

            // variables 
            Char Selection = ' ';       // sert a selectionner le bon menu

            // tant que l'utilisateur n'a pas entrer une valeur entre 1 et 5 recommence
            do
            {
                Selection = Console.ReadKey(true).KeyChar;
            }
            while (Selection < '1' || Selection > '5');

            // selectionne la bonne méthode
            switch (Selection)
            {
                case '1':

                    break;
                case '2':
                    Option();
                    break;
                case '3':
                    Menu();
                    break;
                default:
                    break;
            }

        }

        static void HighScore()
        {

        }

        static void Propos()
        {
        }

        //static void Music(bool musicOn)
        //{
        //    var myPlayer = new System.Media.SoundPlayer();

        //    if (musicOn == true)
        //    {
        //        myPlayer.SoundLocation = @"C:\Users\sofethenoz\Desktop\Menu\Muic1.wav";
        //        myPlayer.Play();
        //    }
        //    else
        //    {
        //        myPlayer.Stop();
        //    }
        //}
    }
}
