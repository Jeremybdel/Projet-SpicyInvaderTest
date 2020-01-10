///ETML
///Auteur : Ethenoz Sofian
///Date : 18.11.2019
///Description : lancement du menu 
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
            // création de deux objets
            Game game = new Game();
            Menu menu = new Menu(game);

            // Lancement du menu
            menu.MenuGeneral();
        }
    }
}


