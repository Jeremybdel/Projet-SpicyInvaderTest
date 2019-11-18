using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NewSpicyVader
{
    class Program
    {
        static void Main(string[] args)
        {
            // création d'objet
            Player joueur = new Player();
            Ennemy ennemi = new Ennemy();

            // appelle de méthode
            joueur.DrawPlayer();
            ennemi.DrawEnnemi1(0, 0);
            ennemi.DrawEnnemi2(0, 0);
            ennemi.DrawEnnemi3(0, 0);          
            
            ConsoleKeyInfo InputKey1;

            long timer = 0;

            while (true)
            {
                timer++;

                InputKey1 = new ConsoleKeyInfo((char)ConsoleKey.P, ConsoleKey.P, false, false, false);

                if (Console.KeyAvailable)
                {
                    InputKey1 = Console.ReadKey(true);
                }

                if (timer % 5000 == 0)
                {
                    ennemi.DeplacementEnnemi();
                }

                if (InputKey1.Key == ConsoleKey.Spacebar && joueur.isFired == false)
                {
                    joueur.isFired = true;
                }


                if (timer % 2000 == 0)
                {
                    joueur.Shooting(InputKey1.Key);
                }

                joueur.Deplacement(InputKey1.Key);
            }
        }
    }
}


