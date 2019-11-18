using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NewSpicyVader
{
    public class Ennemy
    {


        public string ennemy1 = (@"
   ▄██▄
 ▄██████▄
███▄██▄███
  ▄▀▄▄▀▄    
 ▀ ▀  ▀ ▀");
        public string ennemy2 = (@"
   ▄██▄
 ▄██████▄
███▄██▄███
  ▄▀  ▀▄
   ▀  ▀  ");
        public string ennemy3 = (@"
 ▄▄████▄▄
██████████
██▄▄██▄▄██
 ▄▀▄▀▀▄▀▄
▀        ▀");
        public string ennemy4 = (@"
 ▄▄████▄▄
██████████
██▄▄██▄▄██
 ▄▀▄▀▀▄▀▄
  ▀    ▀  ");
        public string ennemy5 = (@"
▄ ▀▄   ▄▀ ▄
█▄███████▄█
███▄███▄███
▀█████████▀
 ▄▀     ▀▄  ");
        public string ennemy6 = (@"
  ▀▄   ▄▀  
 ▄█▀███▀█▄  
█▀███████▀█ 
█ █▀▀▀▀▀█ █ 
   ▀▀ ▀▀   ");
        public string ennemy7 = (@"
    ▄▄████▄▄
  ▄██████████▄
▄██▄██▄██▄██▄██▄
  ▀█▀  ▀▀  ▀█▀");
        /// <summary>
        /// affiche les ennemis 1
        /// </summary>
        public void DrawEnnemi1(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy1.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + positionY);
                    Console.Write(ennemy1.Split('\n')[i]);
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 1
        /// </summary>
        public void DrawEnnemi11(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy2.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + positionY);
                    Console.Write(ennemy2.Split('\n')[i]);
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 2
        /// </summary>
        public void DrawEnnemi2(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy3.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + 7 + positionY);
                    Console.Write(ennemy3.Split('\n')[i]);
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 2
        /// </summary>
        public void DrawEnnemi22(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy4.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + 7 + positionY);
                    Console.Write(ennemy4.Split('\n')[i]);
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 3
        /// </summary>
        public void DrawEnnemi3(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy5.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + 14 + positionY);
                    Console.Write(ennemy5.Split('\n')[i]);
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 3
        /// </summary>
        public void DrawEnnemi33(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy6.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + 14 + positionY);
                    Console.Write(ennemy6.Split('\n')[i]);
                }
            }
        }

        // variable
        int sourceLeft = 0;     // point le plus à gauche
        int sourceTop = 0;      // point le plus en haut
        int sourceWidth = 119;  // grandeur totale en largeur
        int sourceHeight = 20;  // grandeur totale en hauteur
        int targetTop = 0;      // position voulue en haut
        int targetLeft = 0;     // position voulue à gauche

        /// <summary>
        /// Deplacement des ennemis
        /// </summary>
        public void DeplacementEnnemi()
        {
            // déplacement des ennemis
            if (targetTop != 40)
            {         
                // déplacement droite
                if (targetTop % 4 == 0)
                {
                    if (targetLeft < 115)
                    {
                        targetLeft++;

                        if (targetLeft % 6 > 2)
                        {
                            DrawEnnemi11(sourceLeft, sourceTop);
                            DrawEnnemi22(sourceLeft, sourceTop);
                            DrawEnnemi33(sourceLeft, sourceTop);
                        }
                        else if (targetLeft % 6 < 2)
                        {
                            DrawEnnemi1(sourceLeft, sourceTop);
                            DrawEnnemi2(sourceLeft, sourceTop);
                            DrawEnnemi3(sourceLeft, sourceTop);
                        }

                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceLeft++;
                    }
                    else
                    {
                        targetTop += 2;
                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceTop += 2;
                    }
                }
                // déplacement gauche
                else
                {
                    if (targetLeft > 2)
                    {
                        targetLeft--;

                        if (targetLeft % 6 > 2)
                        {
                            DrawEnnemi11(sourceLeft, sourceTop);
                            DrawEnnemi22(sourceLeft, sourceTop);
                            DrawEnnemi33(sourceLeft, sourceTop);
                        }
                        else if (targetLeft % 6 < 2)
                        {
                            DrawEnnemi1(sourceLeft, sourceTop);
                            DrawEnnemi2(sourceLeft, sourceTop);
                            DrawEnnemi3(sourceLeft, sourceTop);
                        }

                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceLeft--;
                    }
                    else
                    {
                        targetTop += 2;
                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceTop += 2;
                    }

                }
            }
        }
    }
}
