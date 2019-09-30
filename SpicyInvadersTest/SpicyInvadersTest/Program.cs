//Auteur : JMY
//Modifié par : jerdelisle
//Date   : 09.09.2018
//Lieu   : ETML
//Description : Squelette pour SpaceInvaders en console

using System;
using System.Collections.Generic;

namespace spaceInvadersSquelette
{
    class Program
    {
        //Graphisme avancé du vaisseau
        const string ship = "■";
        const int shipY = 21; //position verticale du vaisseau
        const char ennemy = '♦';
        const int ennemy_number = 10;

        static void Main(string[] args)
        {
            int shipX = 50;

            int ennemyX = 50;
            int ennemyY = 3;
            List<char>tab_ennemy = new List<char>(ennemy_number);

            int missileX = -1;
            int missileY = -1;

            bool missileFired = false;

            int tics = 0;

            //Rempli le tableau d'ennemies
            for (int i = 0; i < ennemy_number; i++)
            {
                tab_ennemy.Add(ennemy);
            }

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
                            Console.Write(" ");//Effacer l'ancienne position
                            shipX--;

                            break;

                        case ConsoleKey.RightArrow:
                            //Décalage de la position de référence
                            Console.SetCursorPosition(shipX, shipY);
                            Console.Write(" ");//Effacer l'ancienne position
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
                            Console.Write(" ");

                            //AFficher la nouvelle position
                            Console.SetCursorPosition(missileX, --missileY);
                            Console.Write("°");

                            if (missileX == ennemyX && missileY == ennemyY)
                            {
                                tab_ennemy.RemoveAt(ennemyX);
                            }
                        }
                    }
                    else
                    {
                        //Fin du missile
                        missileFired = false;

                        //Effacer l'ancien missile
                        Console.SetCursorPosition(missileX, missileY);
                        Console.Write(" ");
                    }
                }

                //Ennemy movement
                if (tics % 90 == 0)
                {
                    Console.SetCursorPosition(ennemyX, ennemyY);
                    Console.Write("                       ");//Effacer l'ancienne position
                    ennemyX--;

                    if (ennemyX == 25)
                    {
                        ennemyX = 50;
                        ennemyY++;
                    }

                    Console.SetCursorPosition(ennemyX, ennemyY);
                    for (int i = 0; i < tab_ennemy.Count ; i++)
                    {
                        Console.Write(tab_ennemy[i]);
                    }
                }

                //Temporisation FPS
                System.Threading.Thread.Sleep(1);


                tics++;
                if (tics == Int32.MaxValue)
                    tics = 0;


            }

        }
    }
}

