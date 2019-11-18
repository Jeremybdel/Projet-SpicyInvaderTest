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
                    //case ConsoleKey.Spacebar:
                        bool missileFired = true;

                        Missile newMissile = new Missile();
                       // newMissile.Draw(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, missileFired);

                        //while (missileFired)
                        //{
                        //        newMissile.Shoot();
                        //        missileFired = false;
                        //}
                        //break;
                }

            }
            
        }

    }
}
