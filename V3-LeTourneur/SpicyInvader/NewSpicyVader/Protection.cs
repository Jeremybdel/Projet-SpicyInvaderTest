///ETML
///Auteur : Ethenoz Sofian
///Date : 18.11.2019
///Description : Murs de protection du joueur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpicyVader
{
    class Protection
    {
        const int TAILLEX = 20;
        const int TAILLEY = 5;

        private int positionX;
        private int positionY;

        const char SPRITEFULL = '█';
        const char SPRITEHALF = '▀';
        const char SPRITEEMPTY = ' ';

        char[,] walls = new char[TAILLEX,TAILLEY];

        public int nbWall = TAILLEX * TAILLEY;

        /// <summary>
        /// Positionnement du mur
        /// </summary>
        /// <param name="_positionX"></param>
        /// <param name="_positionY"></param>
        public Protection(int _positionX, int _positionY)
        {
            positionX = _positionX;
            positionY = _positionY;

            for(int x = 0; x < TAILLEX; x++)
            {
                for (int y = 0; y < TAILLEY; y++)
                {
                    walls[x, y] = SPRITEFULL;
                }
            }
        }

        /// <summary>
        /// Affichage du mur
        /// </summary>
        public void Draw()
        {
            for (int x = 0; x < TAILLEX; x++)
            {
                for (int y = 0; y < TAILLEY; y++)
                {
                    Console.SetCursorPosition(positionX + x, positionY + y);
                    Console.Write(SPRITEFULL);
                }
            }
        }

        /// <summary>
        /// hitbox du mur
        /// </summary>
        /// <param name="missile"></param>
        /// <returns></returns>
        public bool IsShot(Bullet missile)
        {
            for (int x = 0; x < TAILLEX; x++)
            {
                for (int y = 0; y < TAILLEY; y++)
                {
                    if (missile.positionX == positionX + x && positionY + y == missile.positionY)
                    {
                         if (walls[x,y] == SPRITEFULL)
                        {
                            walls[x, y] = SPRITEHALF;
                            Console.SetCursorPosition(positionX + x, positionY + y);
                            Console.Write(SPRITEHALF);
                            return true;
                        }else if(walls[x,y] == SPRITEHALF)
                        {
                            walls[x, y] = SPRITEEMPTY;
                            Console.SetCursorPosition(positionX + x, positionY + y);
                            Console.Write(SPRITEEMPTY);
                            nbWall--;
                            return true;
                        }else if(walls[x, y] == SPRITEEMPTY)
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }
    }
}
