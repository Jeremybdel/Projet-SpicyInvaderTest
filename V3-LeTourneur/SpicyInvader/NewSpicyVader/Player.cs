///ETML
///Auteur : Ethenoz Sofian
///Date : 18.11.2019
///Description : Cette class permet de donner des attibuts au joueur, sa position, ses déplacements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NewSpicyVader
{
    public class Player
    {
        // variables 
        int left = 100;         // position gauche du joueur
        private int targetLeft = 106;   // position de tir du missile
        public int TargetLeft { get=>targetLeft; }


        string player = (@"      ▄
     ███
▄███████████▄
█████████████
█████████████");

        /// <summary>
        /// affiche le joueur
        /// </summary>
        public void DrawPlayer()
        {
            for (int i = 0; i < player.Split('\n').Length; ++i)
            {
                Console.SetCursorPosition(left, 70+i);
                Console.Write(player.Split('\n')[i]);
            }
        }

        /// <summary>
        /// déplacement du joueurs
        /// </summary>
        public void Deplacement(ConsoleKey input)
        {
            // empêche le joueur de sortir de la console du côté gauche
            if (left > 1)
            {
                if (input == ConsoleKey.LeftArrow)
                {
                    Console.MoveBufferArea(left, 70, 13, 5, left -= 1, 70);
                    targetLeft -= 1;
                }
            }
            // empêche le joueur de sortir de la console du côté droite
            if (left < 220)
            {
                if (input == ConsoleKey.RightArrow)
                {
                    Console.MoveBufferArea(left, 70, 13, 5, left += 1, 70);
                    targetLeft += 1;
                }
            }
        }
    }
}
