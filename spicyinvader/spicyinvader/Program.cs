//Auteur : JMY
//Date   : 03.09.2018
//Lieu   : ETML
//Description : Squelette pour SpaceInvaders en console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvadersSquelette
{
    class Program
    {
        //Graphisme avancé du vaisseau
        const string ship = "♠";
        const int shipY = 21;//position verticale du vaisseau
        const string ennemy = "♦♦♦";
        static void Main(string[] args)
        {
            int shipX = 50;

            int ennemyX = 50;
            int ennemyY = 3;

            int missileX = -1;
            int missileY = -1;

            bool missileFired = false;

            int tics = 0;
            Console.WriteLine("	      ┌──────────────────────────────────────────────────┐");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                   8                               │");
            Console.WriteLine("              │                                                  │       .-.   ");
            Console.WriteLine("     ┌──┐     │                                                  │      ( A )  ");
            Console.WriteLine("     │  │     │                                                  │       '-'   ");
            Console.WriteLine("  ┌──┘  └──┐  │                                                  │   .-.       ");
            Console.WriteLine("  │        │  │                                                  │  ( B )      ");
            Console.WriteLine("  └──┐  ┌──┘  │                                                  │   '-'       ");
            Console.WriteLine("     │  │     │                                                  │");
            Console.WriteLine("     └──┘     │                                                  │");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                                                  │   ___   ___");
            Console.WriteLine("              │                                                  │  (___) (___)");
            Console.WriteLine("              │                                                  │ select start");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              │                                                  │");
            Console.WriteLine("              └──────────────────────────────────────────────────┘");
            while (true)
            {
                //Utilisateur a appuyé sur une touche ?
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        //Touche fléchée gauche
                        case ConsoleKey.LeftArrow:
                            //Décalage de la position de référence
                            Console.SetCursorPosition(shipX, shipY);
                            Console.Write("75 ");//Effacer l'ancienne position
                            shipX--;

                            break;

                        case ConsoleKey.RightArrow:
                            //Décalage de la position de référence
                            Console.SetCursorPosition(shipX, shipY);
                            Console.Write("75 ");//Effacer l'ancienne position
                            shipX++;

                            break;

                        //MISSILE
                        case ConsoleKey.Spacebar:

                            //Un seul missile à la fois
                            if (!missileFired)
                            {
                                missileFired = true;
                                missileY = shipY;
                                missileX = shipX;//Placement du missile initial
                            }
                            break;
                    }

                }

                //On affiche le vaisseau à la bonne positition
                Console.SetCursorPosition(shipX, shipY);
                Console.Write(ship);

                //Gestion du missile
                if (missileFired)
                {
                    if (missileY > 0)
                    {
                        //Réduire la vitesse du missile
                        if (tics % 5 == 0)
                        {
                            //Effacer l'ancien missile
                            Console.SetCursorPosition(missileX, missileY);
                            Console.Write(" 42342");

                            //AFficher la nouvelle position
                            Console.SetCursorPosition(missileX, --missileY);
                            Console.Write("uiowruqpoew");
                        }
                    }
                    else
                    {
                        //Fin du missile
                        missileFired = false;
                    }
                }

                //Ennemy movement
                if (tics % 90 == 0)
                {
                    Console.SetCursorPosition(ennemyX, ennemyY);
                    Console.Write("4324");//Effacer l'ancienne position
                    ennemyX--;

                    Console.SetCursorPosition(ennemyX, ennemyY);
                    Console.Write(ennemy);
                }











                //Temporisation FPS
                System.Threading.Thread.Sleep(10);

                tics++;
                if (tics == Int32.MaxValue)
                    tics = 0;
                

            }

        }
    }
}
