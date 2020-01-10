///ETML
///Auteur : Ethenoz Sofian
///Date : 18.11.2019
///Description : 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NewSpicyVader
{
    public class Enemy
    {
        // étât de l'ennemi (si vrai = en vie si faux = mort)
        public bool alive = true;

        // position de l'ennemi
        public int positionX = 0;
        public int positionY = 0;

        // taille de l'ennemi 
        public int sizeX = 10;
        public int sizeY = 6;

        // sprite de l'ennemi
        public string sprite;

        /// <summary>
        /// Ht bock de l'ennemi
        /// </summary>
        /// <param name="bullet"></param>
        /// <returns></returns>
        public bool Hit(Bullet bullet)
        {
            if (bullet.positionX >= positionX && bullet.positionX <= positionX + sizeX)
            {
                if (bullet.positionY >= positionY && bullet.positionY <= positionY + sizeY)
                {
                    return true;
                }
            }
            return false;
        }

        // déplacement des ennemis
        public void Move(int positionFirst, int positionLast)
        {
            // déplacement droite
            if (positionY % 4 == 0)
            {
                if (positionLast < 200)
                {

                    // déplacement des ennemis
                    Console.MoveBufferArea(positionX, positionY, sizeX, sizeY, positionX + 1, positionY);
                    positionX++;
                }
                else
                {
                    // déplacement des ennemis
                    Console.MoveBufferArea(positionX, positionY, sizeX, sizeY, positionX, positionY + 2);
                    positionY += 2;
                }
            }
            // déplacement gauche
            else
            {
                if (positionFirst > 2)
                {
                    // déplacement des ennemis
                    Console.MoveBufferArea(positionX, positionY, sizeX, sizeY, positionX - 1, positionY);
                    positionX--;

                    if (!(positionX > 2))
                    {

                        Console.MoveBufferArea(positionX, positionY, sizeX, sizeY, positionX, positionY + 2);
                        positionY += 2;
                    }

                }
                else
                {
                    // déplacement des ennemis
                    Console.MoveBufferArea(positionX, positionY, sizeX, sizeY, positionX, positionY + 2);
                    positionY += 2;
                }

            }

        }

        /// <summary>
        /// écriture des ennemis
        /// </summary>
        public void Draw()
        {
            for (int i = 0; i < sprite.Split('\n').Length; ++i)
            {
                Console.SetCursorPosition(positionX, i + positionY);
                Console.Write(sprite.Split('\n')[i]);

            }

        }

        /// <summary>
        /// suppression des ennemis
        /// </summary>
        public void Delete()
        {
            alive = false;
            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    Console.SetCursorPosition(positionX + x, positionY + y);
                    Console.Write(" ");
                }
            }
        }
    }
}