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
    public class Ennemy
    {
        // variables 
        int positionLargeurMissile = 0;
        int positionHauteurMissile = 0;

        bool[] drawEnnemie1 = new bool[10];
        bool[] drawEnnemie2 = new bool[10];
        bool[] drawEnnemie3 = new bool[10];
        public int IsDead = 0;


        public string ennemy1A = (@"
   ▄██▄     
 ▄██████▄   
███▄██▄███  
  ▄▀▄▄▀▄    
 ▀ ▀  ▀ ▀   
            ");
        public string ennemy1B = (@"
   ▄██▄     
 ▄██████▄   
███▄██▄███  
  ▄▀  ▀▄    
   ▀  ▀     
            ");
        public string ennemy2A = (@"
 ▄▄████▄▄   
██████████  
██▄▄██▄▄██  
 ▄▀▄▀▀▄▀▄   
▀        ▀  
            ");
        public string ennemy2B = (@"
 ▄▄████▄▄   
██████████  
██▄▄██▄▄██  
 ▄▀▄▀▀▄▀▄   
  ▀    ▀    
            ");
        public string ennemy3A = (@"
▄ ▀▄   ▄▀ ▄ 
█▄███████▄█ 
███▄███▄███ 
▀█████████▀ 
 ▄▀     ▀▄  
            ");
        public string ennemy3B = (@"
  ▀▄   ▄▀   
 ▄█▀███▀█▄  
█▀███████▀█ 
█ █▀▀▀▀▀█ █ 
   ▀▀ ▀▀    
            ");
        public string dead= (@"
            
            
            
            
            
            
                
                    
                        ");
        public string ennemy7 = (@"
    ▄▄████▄▄
  ▄██████████▄
▄██▄██▄██▄██▄██▄
  ▀█▀  ▀▀  ▀█▀");
        /// <summary>
        /// affiche les ennemis 1
        /// </summary>
        public void Ennemy1A(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy1A.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + positionY);

                    IsEnnemyAHit(positionX, x, i, positionY);

                    if (drawEnnemie1[x] == true)
                    {
                        Console.Write(ennemy1A.Split('\n')[i]);
                    }
                    else
                    {
                        Console.Write(dead.Split('\n')[i]);
                    }
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 1
        /// </summary>
        public void Ennemy2A(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy1B.Split('\n').Length; ++i)
                {                    
                    Console.SetCursorPosition(x * 12 + positionX, i + positionY);
                    IsEnnemyAHit(positionX, x, i, positionY);

                    if (drawEnnemie1[x] == true)
                    {
                        Console.Write(ennemy1B.Split('\n')[i]);
                    }
                    else
                    {
                        Console.Write(dead.Split('\n')[i]);
                    }
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 2
        /// </summary>
        public void Ennemy1B(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy2A.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + 6 + positionY);
                    IsEnnemyBHit(positionX, x, i, positionY);

                    if (drawEnnemie2[x] == true)
                    {
                        Console.Write(ennemy2A.Split('\n')[i]);
                    }
                    else
                    {
                        Console.Write(dead.Split('\n')[i]);
                    }
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 2
        /// </summary>
        public void Ennemy2B(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy2B.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + 6 + positionY);
                    IsEnnemyBHit(positionX, x, i, positionY);

                    if (drawEnnemie2[x] == true)
                    {
                        Console.Write(ennemy2B.Split('\n')[i]);
                    }
                    else
                    {
                        Console.Write(dead.Split('\n')[i]);
                    }
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 3
        /// </summary>
        public void Ennemy1C(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy3A.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + 12 + positionY);
                    IsEnnemyCHit(positionX, x, i, positionY);

                    if (drawEnnemie3[x] == true)
                    {
                        Console.Write(ennemy3B.Split('\n')[i]);
                    }

                    else
                    {
                        Console.Write(dead.Split('\n')[i]);
                    }
                }
            }
        }

        /// <summary>
        /// affiche les ennemis 3
        /// </summary>
        public void Ennemy2C(int positionX, int positionY)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int i = 0; i < ennemy3B.Split('\n').Length; ++i)
                {
                    Console.SetCursorPosition(x * 12 + positionX, i + 12 + positionY);
                    IsEnnemyCHit(positionX, x, i, positionY);

                    if (drawEnnemie3[x] == true)
                    {
                        Console.Write(ennemy3A.Split('\n')[i]);
                    }
                    else
                    {
                        Console.Write(dead.Split('\n')[i]);
                    }
                }
            }
        }

        // position du missile
        public void PositionBullet(int longeur, int hauteur)
        {
            positionHauteurMissile = hauteur;
            positionLargeurMissile = longeur;
        }

        // variable
        int sourceLeft = 0;     // point le plus à gauche
        int sourceTop = 0;      // point le plus en haut
        int sourceWidth = 119;  // grandeur totale en largeur
        int sourceHeight = 18;  // grandeur totale en hauteur
        int targetTop = 0;      // position voulue en haut
        int targetLeft = 0;     // position voulue à gauche

        /// <summary>
        /// Deplacement des ennemis
        /// </summary>
        public void DeplacementEnnemi()
        {
            // initialisation du tableau qui sert à afficher les ennemis
            if (targetTop == 0 && targetLeft == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    drawEnnemie1[i] = true;
                    drawEnnemie2[i] = true;
                    drawEnnemie3[i] = true;
                }             
            }

            // déplacement des ennemis
            if (targetTop != 40)
            {         
                // déplacement droite
                if (targetTop % 4 == 0)
                {
                    if (targetLeft < 115)
                    {
                        targetLeft++;

                        // Animation des ennemis
                        if (targetLeft % 6 > 2)
                        {
                            Ennemy2A(sourceLeft, sourceTop);
                            Ennemy2B(sourceLeft, sourceTop);
                            Ennemy2C(sourceLeft, sourceTop);
                        }
                        else
                        {
                            Ennemy1A(sourceLeft, sourceTop);
                            Ennemy1B(sourceLeft, sourceTop);
                            Ennemy1C(sourceLeft, sourceTop);
                        }
                        // déplacement des ennemis
                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceLeft++;
                    }
                    else
                    {
                        // déplacement des ennemis
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

                        // Animation des ennemis
                        if (targetLeft % 6 > 2)
                        {
                            Ennemy2A(sourceLeft, sourceTop);
                            Ennemy2B(sourceLeft, sourceTop);
                            Ennemy2C(sourceLeft, sourceTop);
                        }
                        else
                        {
                            Ennemy1A(sourceLeft, sourceTop);
                            Ennemy1B(sourceLeft, sourceTop);
                            Ennemy1C(sourceLeft, sourceTop);
                        }
                        // déplacement des ennemis
                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceLeft--;
                    }
                    else
                    {
                        // déplacement des ennemis
                        targetTop += 2;
                        Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
                        sourceTop += 2;
                    }
                }             
            }            
        }

        /// <summary>
        /// Hit box ennemy de type A
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="x"></param>
        /// <param name="i"></param>
        /// <param name="positionY"></param>
        public void IsEnnemyAHit(int positionX, int x, int i, int positionY)
        {
            for (int y = 0; y < 10; ++y)
            {
                if (positionLargeurMissile == x * 12 + positionX + y                // Si le missile se retrouve sur la même position sur son axe X
                    && positionHauteurMissile == i + positionY + y                  // Si le missile se retrouve sur la même position sur son axe Y
                    && positionHauteurMissile != 0                                  // Si n'est pas arrivé a la marge superieur
                    && drawEnnemie1[x] != false)                                    // Si l'ennemie est deja mort
                {
                    drawEnnemie1[x] = false;
                    Console.Write(dead.Split('\n')[i]);                 //Enemy dies
                    IsDead++;
                    AllEnnemiesAreDead();
                }
            }
        }

        /// <summary>
        /// Hit box ennemy de type B
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="x"></param>
        /// <param name="i"></param>
        /// <param name="positionY"></param>
        public void IsEnnemyBHit(int positionX, int x, int i, int positionY)
        {
            for (int y = 0; y < 10; ++y)
            {
                if (positionLargeurMissile == x * 12 + positionX + y && positionHauteurMissile == i + 6 + positionY + y && positionHauteurMissile != 0 && drawEnnemie2[x] != false)
                {
                    drawEnnemie2[x] = false;
                    Console.Write(dead.Split('\n')[i]);
                    IsDead++;
                    AllEnnemiesAreDead();
                }
            }
        }

        /// <summary>
        /// hit box ennemy de type C
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="x"></param>
        /// <param name="i"></param>
        /// <param name="positionY"></param>
        public void IsEnnemyCHit(int positionX, int x, int i, int positionY)
        {
            for (int y = 0; y < 10; ++y)
            {
                if (positionLargeurMissile == x * 12 + positionX + y && positionHauteurMissile == i + 10 + positionY + y && positionHauteurMissile != 0 && drawEnnemie3[x] != false)
                {
                    drawEnnemie3[x] = false;
                    Console.Write(dead.Split('\n')[i]);
                    IsDead++;
                    AllEnnemiesAreDead();
                }
            }
        }

        public bool AllEnnemiesAreDead()
        {
            if (IsDead <= 29)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
