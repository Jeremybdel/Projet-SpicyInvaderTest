using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NewSpicyVader
{
    public class Player
    {
        int left = 100;
        int targetTop = 68;
        int targetLeft = 106;

        string player = (@"      ▄
     ███
▄███████████▄
█████████████
█████████████");

        /// <summary>
        /// affiche les ennemis 3
        /// </summary>
        public void DrawPlayer()
        {
            for (int i = 0; i < player.Split('\n').Length; ++i)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(player.Split('\n')[i]);
            }
            Console.MoveBufferArea(0, 0, 13, 5, 100, 70);
        }

        /// <summary>
        /// déplacement du joueurs
        /// </summary>
        public void Deplacement(ConsoleKey input)
        {
            if (left > 0)
            {
                if (input == ConsoleKey.LeftArrow)
                {
                    Console.MoveBufferArea(left, 70, 13, 5, left -= 2, 70);
                    targetLeft -= 2;
                }
            }

            if (left < 220)
            {
                if (input == ConsoleKey.RightArrow)
                {
                    Console.MoveBufferArea(left, 70, 13, 5, left += 2, 70);
                    targetLeft += 2;
                }
            }
        }

        public bool isFired = false;

        /// <summary>
        /// Tire un missile
        /// </summary>
        /// <param name="input"></param>
        public void Shooting(ConsoleKey input)
        {
            if (isFired)
            {
                if (targetTop >= 0)
                {
                    Console.SetCursorPosition(targetLeft, targetTop--);
                    Console.Write("I");
                    Console.SetCursorPosition(targetLeft, targetTop + 2);
                    Console.Write(" ");
                }
                else
                {
                    isFired = false;
                }
            }
            else
            {
                targetTop = 68;
            }
        }
    }
}
