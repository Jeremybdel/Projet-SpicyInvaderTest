///ETML
///Auteur : Ethenoz Sofian
///Date : 18.11.2019
///Description : instance principal, Déroulement de la partie.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpicyVader
{
    class Game
    {
        public void LaunchGame(bool sound, int difficulti)
        {
            // Change la taille du buffer
            Console.BufferWidth = 800;

            bool victoire = false;
            bool defaite = false;

            // rends invisible le curseur
            Console.CursorVisible = false;


            // change la couleur de la console
            Console.ForegroundColor = ConsoleColor.Green;

            int score = 0;
            int life = 3;

            // création d'objet
            Player joueur = new Player();

            List<EnemyA> enemysA = new List<EnemyA>();
            List<EnemyB> enemysB = new List<EnemyB>();
            List<EnemyC> enemysC = new List<EnemyC>();
            Bullet missile = new Bullet();
            List<Protection> protection = new List<Protection>();

            //Lire musique
            //Lire difficulté
            do {

                enemysA.Clear();
                enemysB.Clear();
                enemysC.Clear();

                protection.Clear();

                life--;
                score = 0;
                defaite = false;

                Console.Clear();

                Console.SetCursorPosition(180, 78);
                Console.Write("score : " + score);
                Console.SetCursorPosition(10, 78);
                Console.Write("Nombre de vie restante : " + life);

                for (int x = 0; x < 4; x++)
                {
                    protection.Add(new Protection(x * 30 + 40, 50));
                    protection[x].Draw();
                }
                for (int x = 0; x < 10; x++)
                {
                    enemysA.Add(new EnemyA(x * 15, 0));
                    enemysA[x].Draw();

                    enemysB.Add(new EnemyB(x * 15, 8));
                    enemysB[x].Draw();

                    enemysC.Add(new EnemyC(x * 15, 16));
                    enemysC[x].Draw();


                }
                // appelle de méthode
                joueur.DrawPlayer();

                ConsoleKeyInfo InputKey1;

                ulong timer = 0;

                // Multi Thread sans multi tread
                while (!victoire && !defaite)
                {
                    // incrementation du timer
                    timer++;


                    // si une touche à été enfoncée
                    if (Console.KeyAvailable)
                    {
                        // recupère le caractère qui à été utilisé 
                        InputKey1 = Console.ReadKey(true);

                        // tire de missile si barre espace enfoncée
                        if (InputKey1.Key == ConsoleKey.Spacebar && missile.isFired == false)
                        {
                            missile.positionX = joueur.TargetLeft;

                            // si le missile est tiré = true sinon false
                            missile.isFired = true;
                        }

                        joueur.Deplacement(InputKey1.Key);

                    }

                    // gère le déplacement des enemys
                    if (timer % Convert.ToUInt64(5000/difficulti) == 0)
                    {
                        int oldLastPositionA = 0;
                        int oldLastPositionB = 0;
                        int oldLastPositionC = 0;

                        int oldFirstPositionA = 200;
                        int oldFirstPositionB = 200;
                        int oldFirstPositionC = 200;

                        if (enemysA.Count != 0)
                        {
                            oldFirstPositionA = enemysA[0].positionX;
                            oldLastPositionA = enemysA[enemysA.Count - 1].positionX;
                        }

                        if (enemysB.Count != 0)
                        {
                            oldFirstPositionB = enemysB[0].positionX;
                            oldLastPositionB = enemysB[enemysB.Count - 1].positionX;
                        }

                        if (enemysC.Count != 0)
                        {
                            oldFirstPositionC = enemysC[0].positionX;
                            oldLastPositionC = enemysC[enemysC.Count - 1].positionX;
                        }

                        if (enemysA.Count != 0)
                        {
                            for (int i = 0; i < enemysA.Count; i++)
                            {
                                enemysA[i].Move(CalculFirstLong('a', oldFirstPositionA, oldFirstPositionB, oldFirstPositionC), CalculLastLong('a', oldLastPositionA, oldLastPositionB, oldLastPositionC));
                            }
                        }

                        if (enemysB.Count != 0)
                        {
                            for (int i = 0; i < enemysB.Count; i++)
                            {
                                enemysB[i].Move(CalculFirstLong('b', oldFirstPositionA, oldFirstPositionB, oldFirstPositionC), CalculLastLong('b', oldLastPositionA, oldLastPositionB, oldLastPositionC));
                            }
                        }

                        if (enemysC.Count != 0)
                        {
                            for (int i = 0; i < enemysC.Count; i++)
                            {
                                enemysC[i].Move(CalculFirstLong('c', oldFirstPositionA, oldFirstPositionB, oldFirstPositionC), CalculLastLong('c', oldLastPositionA, oldLastPositionB, oldLastPositionC));
                            }
                        }

                    }



                    // déplacement du missile
                    if (timer % 1500 == 0 && missile.isFired == true)
                    {
                        // Tir d'un missile
                        missile.Shooting();

                        // appelle une méthode qui donne les coordonnées du missile à la méthode qui gère la hit box
                        for (int i = 0; i < enemysA.Count; i++)
                        {
                            if (enemysA[i].Hit(missile))
                            {
                                enemysA[i].Delete();
                                enemysA.RemoveAt(i);
                                missile.BulletDies();
                                score += 50;
                            }
                        }

                        for (int i = 0; i < enemysB.Count; i++)
                        {
                            if (enemysB[i].Hit(missile))
                            {
                                enemysB[i].Delete();
                                enemysB.RemoveAt(i);
                                missile.BulletDies();
                                score += 50;
                            }
                        }

                        for (int i = 0; i < enemysC.Count; i++)
                        {
                            if (enemysC[i].Hit(missile))
                            {
                                enemysC[i].Delete();
                                enemysC.RemoveAt(i);
                                missile.BulletDies();
                                score += 50;
                            }
                        }

                        for (int i = 0; i < protection.Count; i++)
                        {
                            if (protection[i].IsShot(missile))
                            {
                                missile.BulletDies();
                                if (protection[i].nbWall == 0)
                                {
                                    protection.RemoveAt(i);
                                }
                            }
                        }

                        Console.SetCursorPosition(180, 78);
                        Console.Write("score : " + score);
                    }

                    if (enemysC.Count != 0 && enemysC[0].positionY >= 40)
                    {
                        defaite = true;
                    }

                    if (enemysB.Count != 0 && enemysB[0].positionY >= 40)
                    {
                        defaite = true;
                    }

                    if (enemysA.Count != 0 && enemysA[0].positionY >= 40)
                    {
                        defaite = true;
                    }

                    if (enemysA.Count == 0 && enemysB.Count == 0 && enemysC.Count == 0)
                    {
                        victoire = true;
                    }

                }
            } while (life != 0 && !victoire);

            if (victoire) {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Bravo la menace a été éliminée");
            }
            if (life == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Game Over");
            }
            Console.WriteLine("Votre score est de : " + score);
            Console.Write("Quel est votre pseudo?");
            string pseudo = Console.ReadLine();

            System.IO.File.AppendAllText(@"..\..\Ressource\Score.txt", pseudo + " " + Convert.ToString(score) + Environment.NewLine);

            Console.WriteLine("Votre score a été enregistré cliqué sur une touche pour retourner au menu");
            Console.ReadKey();


        }

        /// <summary>
        /// alcule la positions des ennemis pour raccourcir les lignes
        /// </summary>
        /// <param name="typeEnnemi"></param>
        /// <param name="positionA"></param>
        /// <param name="positionB"></param>
        /// <param name="positionC"></param>
        /// <returns></returns>
        static int CalculLastLong(char typeEnnemi, int positionA, int positionB, int positionC)
        {

            if (typeEnnemi == 'a')
            {
                if (positionA >= positionB && positionA >= positionC)
                {
                    return positionA;
                }
                else if ((positionB >= positionC && positionB >= positionA))
                {
                    return positionB;
                }

                return positionC;
            }
            else if (typeEnnemi == 'b')
            {
                if (positionA >= positionB && positionA >= positionC)
                {
                    return positionA;
                }
                else if ((positionB >= positionC && positionB >= positionA))
                {
                    return positionB;
                }

                return positionC;
            }

            if (positionA >= positionB && positionA >= positionC)
            {
                return positionA;
            }
            else if (positionB >= positionC && positionB >= positionA - 2)
            {
                return positionB;
            }

            return positionC;
        }

        /// <summary>
        /// Calcule la positions des ennemis pour raccourcir les lignes
        /// </summary>
        /// <param name="typeEnnemi"></param>
        /// <param name="positionA"></param>
        /// <param name="positionB"></param>
        /// <param name="positionC"></param>
        /// <returns></returns>
        static int CalculFirstLong(char typeEnnemi, int positionA, int positionB, int positionC)
        {

            if (typeEnnemi == 'a')
            {
                if (positionA <= positionB && positionA <= positionC)
                {
                    return positionA;
                }
                else if ((positionB <= positionC && positionB <= positionA))
                {
                    return positionB;
                }

                return positionC;
            }
            else if (typeEnnemi == 'b')
            {
                if (positionA <= positionB && positionA <= positionC)
                {
                    return positionA;
                }
                else if ((positionB <= positionC && positionB <= positionA))
                {
                    return positionB;
                }

                return positionC;
            }

            if (positionA <= positionB && positionA <= positionC)
            {
                return positionA;
            }
            else if (positionB <= positionC && positionB <= positionA - 2)
            {
                return positionB;
            }

            return positionC;
        }
    }
    
}
