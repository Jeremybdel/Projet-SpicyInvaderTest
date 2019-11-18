using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Ennemy neme = new Ennemy();
            neme.DeplacementEnnemi();
        }
        class Ennemy
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
 ▄▀     ▀▄");
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

            /// <summary>
            /// Deplacement des ennemis
            /// </summary>
            public void DeplacementEnnemi()
            {
                // appelle des méthodes qui affiche les ennemis
                DrawEnnemi1(0, 0);
                DrawEnnemi2(0, 0);
                DrawEnnemi3(0, 0);

                // variable
                int difficulty = 50;
                int sourceLeft = 0;
                int sourceTop = 0;
                int sourceWidth = 119;
                int sourceHeight = 20;
                int targetTop = 0;
                int targetLeft = 0;

                // déplacement des ennemis
                while (true)
                {
                    if (targetTop == 40)
                    {
                        break;
                    }
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

                            Thread.Sleep(difficulty);
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

                            Thread.Sleep(difficulty);
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
}
