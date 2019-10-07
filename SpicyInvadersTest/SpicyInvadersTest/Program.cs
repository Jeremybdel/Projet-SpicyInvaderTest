//Auteur : JMY
//Modifié par : jerdelisle
//Date   : 09.09.2018
//Lieu   : ETML
//Description : Squelette pour SpaceInvaders en console

using System;
using System.Collections.Generic;

namespace spaceInvadersSquelette
{
    class Program
    {
        //Graphisme avancé du vaisseau



        static void Main(string[] args)
        {
            Ennemy.DrawEnnemies();
            Ship.DrawShip();

            while (true)
            {
                Ennemy.MoveEnnemy();
                Ship.MoveShip();
                Ennemy.tics++;
            }

            ////Temporisation FPS
            //System.Threading.Thread.Sleep(10);


        }

    }
    }


