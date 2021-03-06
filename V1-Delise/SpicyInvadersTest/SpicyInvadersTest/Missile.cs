﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace spaceInvadersSquelette
{
    class Missile
    {
        //Variable
        const char missile = 'O';


        private bool missileFired;
        private int sourceLeft;
        private int sourceTop;
        private int sourceWidth;
        private int sourceHeight;
        private int targetLeft;
        private int targetTop;
        static private int tics = 0;
        static private int temp = 50000;

        public void Draw(int _sourceLeft, int _sourceTop, int _sourceWidth, int _sourceHeight, int _targetLeft, int _targetTop, bool _missileFired)
        {
            sourceLeft = _sourceLeft;
            sourceTop = _sourceTop - 2;
            sourceWidth = _sourceWidth;
            sourceHeight = _sourceHeight;
            targetLeft = _targetLeft;
            targetTop = _targetTop - 2;

            missileFired = _missileFired;
        }

        public void Shoot()
        {   
            //Réduire la vitesse du missile
            if (tics % temp == 0)
            {
                do
                {
                    //Gestion du missile
                    if (missileFired)
                    {
                        Console.SetCursorPosition(targetLeft, sourceTop);
                        Console.Write(missile);
                        for (; targetTop > 0; targetTop--)
                        {
                            Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        }

                            //Fin du missile
                            missileFired = false;
                    }
                } while (missileFired);

            }
        }
    }
}
