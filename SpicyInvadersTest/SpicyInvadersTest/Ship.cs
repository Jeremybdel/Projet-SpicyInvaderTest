using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceInvadersSquelette
{
    class Ship
    {
        //Variable
        const string ship = "■";
        const int shipY = 21;
        static private int shipX = 50;

        static private int sourceLeft = 50;
        static private int sourceTop = 21;
        static private int sourceWidth = 1;
        static private int sourceHeight = 1;
        static private int targetLeft = 50;
        static private int targetTop = 21;
        static private int tics = 0;
        static private int temp = 1;

        const string missile = "*";
        static private int missileX = -1;
        static private int missileY = -1;

        static private bool missileFired = false;

        /// <summary>
        /// Affichage du vaisseau
        /// </summary>
        static public void DrawShip()
        {
            Console.SetCursorPosition(shipX, shipY);
            Console.Write(ship);
        }

        /// <summary>
        /// Mouvement du vaisseau
        /// </summary>
        static public void MoveShip()
        {
            //Mouvement par rappot au flèches
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        targetLeft--;
                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceLeft--;
                        break;

                    case ConsoleKey.RightArrow:
                        targetLeft++;
                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceLeft++;
                        break;

                    //MISSILE
                    case ConsoleKey.Spacebar:

                        //Un seul missile à la fois
                        if (!missileFired)
                        {
                            missileFired = true;
                            missileY = targetLeft;
                            missileX = targetTop;
                        }
                        break;
                }

            }
            
        }

        //static public void Shoot()
        //{
        //    //Gestion du missile
        //    if (missileFired)
        //    {
        //        if (missileY > 0)
        //        {
        //            //Réduire la vitesse du missile
        //            if (tics % temp == 0)
        //            {
        //                Console.Write(missile);
        //                for (; missileY > 0; missileY--)
        //                {
        //                    Console.MoveBufferArea(sourceLeft, sourceTop++, sourceWidth, sourceHeight, targetLeft, targetTop++);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            //Fin du missile
        //            missileFired = false;
        //        }
        //    }

        //}
    }
}
