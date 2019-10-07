using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace spaceInvadersSquelette
{
    class Ennemy
    {
        //Variable
        const char ennemy = '♦';
        const int ennemy_number = 10;
        const int ennemy_height = 5;

        static private int sourceLeft = 1;
        static private int sourceTop = 0;
        static private int sourceWidth = 19;
        static private int sourceHeight = 9;
        static private int targetLeft = 2;
        static private int targetTop = 0;
        static private int x = 0;
        static private int y = 0;
        static private int DistanceLargeur = 60;
        static private int DistanceHauteur = 6;
        static private bool direction = false;
        static public int tics = 0;
        static private int temp = 5000;

        /// <summary>
        /// Affichage des ennemies
        /// </summary>
        static public void DrawEnnemies()
        {
            for (int y = 0; y < ennemy_height; y++)
            {
                for (int x = 0; x < ennemy_number; x++)
                {
                    Console.Write(" " + ennemy);
                }
                Console.Write("\n");
            }
        }


        /// <summary>
        /// Movement des ennemies
        /// </summary>
        static public void MoveEnnemy ()
        {
            //
            if (tics % temp == 0)
            {
                //
                for (; x < DistanceHauteur;)
                {
                    for (; y < DistanceLargeur;)
                    {
                        //
                        switch (direction)
                        {
                            case false:
                                Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                                sourceLeft++;
                                targetLeft++;
                                break;
                            case true:
                                targetLeft--;
                                sourceLeft--;
                                Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                                break;
                        }
                        y++;
                        return;
                    }
                    x++;
                    y = 0;
                    direction = !direction;
                    //
                    if (direction == true)
                    {
                        sourceLeft = DistanceLargeur + 1;
                        targetLeft = DistanceLargeur;
                    }
                    else
                    {
                        sourceLeft = 0;
                        targetLeft = 1;
                    }
                    //
                    targetTop += 1;
                    Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                    sourceTop += 1;
                }
            }
        }
    }
}

