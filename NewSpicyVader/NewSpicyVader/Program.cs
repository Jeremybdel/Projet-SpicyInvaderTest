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
    /// <summary>
    /// Main program cycle
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program Entry Point
        /// </summary>
        static void Main()
        {
            // rends invisible le curseur
            Console.CursorVisible = false;

            // change la couleur de la console
            Console.ForegroundColor = ConsoleColor.Green;

            // création d'objet
            Player joueur = new Player();
            Ennemy ennemi = new Ennemy();
            Bullet missile = new Bullet();

            // appelle de méthode
            joueur.DrawPlayer();      
            
            ConsoleKeyInfo InputKey1;

            ulong timer = 0;

            // Multi Thread sans multi tread
            while (true)
            {
                // incrementation du timer
                timer++;

                // recupère l'input de l'utilisateur
                InputKey1 = new ConsoleKeyInfo((char)ConsoleKey.P, ConsoleKey.P, false, false, false);

                // si une touche à été enfoncée
                if (Console.KeyAvailable)
                {
                    // recupère le caractère qui à été utilisé 
                   InputKey1 = Console.ReadKey(true);
                }
                
                // gère le déplacement des ennemis
                if (timer % 5000 == 0)
                {
                    ennemi.DeplacementEnnemi();
                }

                // tire de missile si barre espace enfoncée
                if (InputKey1.Key == ConsoleKey.Spacebar && missile.isFired == false)
                {
                    missile.BulletX = joueur.TargetLeft;

                    // si le missile est tiré = true sinon false
                    missile.isFired = true;
                }

                // déplacement du missile
                if (timer % 2000 == 0)
                {
                    // Tir d'un missile
                    missile.Shooting();

                    // appelle une méthode qui donne les coordonnées du missile à la méthode qui gère la hit box
                    ennemi.PositionBullet(missile.BulletX, missile.SourceTop);
                } 

                // déplacement du joueur
                joueur.Deplacement(InputKey1.Key);
            }
        }
    }
}


