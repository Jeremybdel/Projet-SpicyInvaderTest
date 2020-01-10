///ETML
///Auteur : Ethenoz Sofian
///Date : 18.11.2019
///Description : La class Bullet sert à donner des attributs aux missiles
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpicyVader
{
    public class Bullet
    {

        // variables
        public bool isFired = false;        // si un tir est en court = vrai sinon false
        public int positionX { get; set; }                // position X du missile (hauteur)
        public int positionY { get; set; } = 68;          // position de départ du missile     

        /// <summary>
        /// Tir d'un missile
        /// </summary>
        /// <param name="input"></param>
        public void Shooting()
        {
            
                // si le missile n'est pas en dehors de la console
                if (positionY >= 0)
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

        // mort du missile
        public void BulletDies()
        {
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(" ");
            isFired = false;
            positionY = 68;
        }

        // déplacement du missile
        public void BulletMoves()
        {
            Console.SetCursorPosition(positionX, positionY--);
            Console.Write("I");
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(" ");
        }
    }
}
