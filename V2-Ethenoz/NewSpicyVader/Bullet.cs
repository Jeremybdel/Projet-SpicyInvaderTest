using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpicyVader
{
    class Bullet
    {

        // variables
        public bool isFired = false;        // si un tir est en court = vrai sinon false
        private int bulletX;                // position X du missile (hauteur)
        public int BulletX { get => bulletX; set => bulletX = value; }
        public int SourceTop = 64;          // position de départ du missile     

        /// <summary>
        /// Tir d'un missile
        /// </summary>
        /// <param name="input"></param>
        public void Shooting(/*ConsoleKey input*/)
        {
            // si le missile à été tiré
            if (isFired)
            {
                // si le missile n'est pas en dehors de la console
                if (SourceTop >= 0)
                {
                    // appelle de la méthode
                    BulletMoves();
                }
                else
                {
                    // appelle de la méthode
                    BulletDies();
                }
            }
            else
            {
                // appelle de la méthode
                BulletDies();
                // change la hauteur du missile pour le faire revenir à la hauteur de départ
                SourceTop = 68;
            }
        }

        // mort du missile
        public void BulletDies()
        {
            Console.SetCursorPosition(BulletX, SourceTop += 1);
            Console.Write("   ");
            isFired = false;
        }

        // déplacement du missile
        public void BulletMoves()
        {
            Console.SetCursorPosition(BulletX, SourceTop--);
            Console.Write("I");
            Console.SetCursorPosition(BulletX, SourceTop + 2);
            Console.Write(" ");
        }
    }
}
