using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NewSpicyVader
{
    class Menu
    {
        private bool sound = false;
        private int difficulteJedi = 1;
        private Game game;


        /// <summary>
        /// constructeur de la class Menu
        /// </summary>
        /// <param name="_game"></param>
        public Menu(Game _game)
        {
            game = _game;
        }

        /// <summary>
        /// affichage du titre
        /// </summary>
        public void Etml()
        {
            Console.SetWindowSize(110, 42);

            Console.Clear();

            Console.SetCursorPosition(8, 3);
            Console.WriteLine("███████╗██████╗ ██╗ ██████╗██╗   ██╗   ██╗███╗   ██╗██╗   ██╗ █████╗ ██████╗ ███████╗██████╗ ");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("██╔════╝██╔══██╗██║██╔════╝╚██╗ ██╔╝   ██║████╗  ██║██║   ██║██╔══██╗██╔══██╗██╔════╝██╔══██╗");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("███████╗██████╔╝██║██║      ╚████╔╝    ██║██╔██╗ ██║██║   ██║███████║██║  ██║█████╗  ██████╔╝");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("╚════██║██╔═══╝ ██║██║       ╚██╔╝     ██║██║╚██╗██║╚██╗ ██╔╝██╔══██║██║  ██║██╔══╝  ██╔══██╗");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("███████║██║     ██║╚██████╗   ██║      ██║██║ ╚████║ ╚████╔╝ ██║  ██║██████╔╝███████╗██║  ██║");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("╚══════╝╚═╝     ╚═╝ ╚═════╝   ╚═╝      ╚═╝╚═╝  ╚═══╝  ╚═══╝  ╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝");
        }

        /// <summary>
        /// Affichage du menu
        /// </summary>
        public void MenuGeneral()
        {
            // variables 
            int index = 0;
            Etml();
            Console.SetCursorPosition(47, 15);
            Console.WriteLine("1 : Jouer");
            Console.SetCursorPosition(47, 18);
            Console.WriteLine("2 : Options");
            Console.SetCursorPosition(47, 21);
            Console.WriteLine("3 : HighScore");
            Console.SetCursorPosition(47, 24);
            Console.WriteLine("4 : A Propos");
            Console.SetCursorPosition(47, 27);
            Console.WriteLine("5 : Quitter");
            Console.SetCursorPosition(47, 15 + index * 3);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Jouer();
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Option();
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            HighScore();
                            break;

                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            Propos();
                            break;

                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            Environment.Exit(1);
                            break;


                        //Touche fléchée gauche
                        case ConsoleKey.UpArrow:
                            if (index > 0)
                            {
                                index--;
                            }

                            break;

                        //Touche fléchée gauche
                        case ConsoleKey.DownArrow:
                            if (index < 4)
                            {
                                index++;
                            }

                            break;

                        case ConsoleKey.Enter:

                            switch (index)
                            {
                                case 0:
                                    Jouer();
                                    break;
                                case 1:
                                    Option();
                                    break;
                                case 2:
                                    HighScore();
                                    break;
                                case 3:
                                    Propos();
                                    break;
                                case 4:
                                    Environment.Exit(1);
                                    break;
                            }
                            break;
                    }

                    Console.SetCursorPosition(47, 15 + index * 3);
                }

            }
        }

        /// <summary>
        /// Action qui permet de lancer le jeu
        /// </summary>
        public void Jouer()
        {
            game.LaunchGame(sound,difficulteJedi);
            Console.Clear();

            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Gray;
            MenuGeneral();
        }

        /// <summary>
        /// affiche les options
        /// </summary>
        public void Option()
        {

            int index = 0;
            
            Etml();
            Console.SetCursorPosition(47, 15);
            if (sound)
            {
                Console.WriteLine("1 : Music (ON)");
            }
            else
            {
                Console.WriteLine("1 : Music (OFF)");
            }
            Console.SetCursorPosition(47, 18);
            if (difficulteJedi == 2)
            {
                Console.WriteLine("2 : Difficulté (Jedi)");
            }
            else
            {
                Console.WriteLine("2 : Difficulté (Padawan)");
            }
            
            Console.SetCursorPosition(47, 21);
            Console.WriteLine("3 : Retour au Menu");
            Console.SetCursorPosition(47, 15);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            index = 0;
                            Console.SetCursorPosition(47, 15 + index * 3);
                            if (sound)
                            {
                                sound = false;
                                Console.WriteLine("1 : Music (OFF)   ");
                                Music(sound);
                            }
                            else
                            {
                                sound = true;
                                Console.WriteLine("1 : Music (ON)   ");
                                Music(sound);
                            }
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            index = 1;
                            Console.SetCursorPosition(47, 15 + index * 3);
                            if (difficulteJedi == 2 )
                            {
                                difficulteJedi = 1;
                                Console.WriteLine("2 : Difficulté (Padawan)");
                            }
                            else
                            {
                                difficulteJedi = 2;
                                Console.WriteLine("2 : Difficulté (Jedi)      ");

                            }
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            MenuGeneral();
                            break;

                        //Touche fléchée gauche
                        case ConsoleKey.UpArrow:
                            if (index > 0)
                            {
                                index--;
                            }

                            break;

                        //Touche fléchée gauche
                        case ConsoleKey.DownArrow:
                            if (index < 2)
                            {
                                index++;
                            }

                            break;

                        case ConsoleKey.Enter:

                            switch (index)
                            {
                                case 0:
                                    if (sound)
                                    {
                                        sound = false;
                                        Console.WriteLine("1 : Music (OFF)   ");
                                        Music(sound);
                                    }
                                    else
                                    {
                                        sound = true;
                                        Console.WriteLine("1 : Music (ON)   ");
                                        Music(sound);
                                    }
                                    break;
                                case 1:
                                    if (difficulteJedi == 2)
                                    {
                                        difficulteJedi = 1;
                                        Console.WriteLine("2 : Difficulté (Padawan)");
                                    }
                                    else
                                    {
                                        difficulteJedi = 2;
                                        Console.WriteLine("2 : Difficulté (Jedi)      ");
                                        
                                    }
                                    break;
                                case 2:
                                    MenuGeneral();
                                    break;
                            }
                            break;
                        
                    }

                    Console.SetCursorPosition(47, 15 + index * 3);
                }

            }

        }

        /// <summary>
        /// affiche le high Score
        /// </summary>
        public void HighScore()
        {
            Console.Clear();
            Etml();
            // Instancier un objet de lecture.
            StreamReader objFichierALire = new StreamReader(@"..\..\Ressource\Score.txt");

            int i = 0;

            // Tant qu'il y a des caractères à lire
            while (!objFichierALire.EndOfStream)
            {
                Console.SetCursorPosition(45, 13 + i);
                // Lire une ligne du fichier.
                string ligneLue = objFichierALire.ReadLine();

                // Afficher la ligne lue sur la console.
                Console.Write(ligneLue);
                
                i += 3;
            }
            // Fermer le fichier.
            objFichierALire.Close();
            Console.ReadKey();
            MenuGeneral();
        }
        
        /// <summary>
        /// affiche les créateurs de l'application
        /// </summary>
        public void Propos()
        {
            Console.Clear();
            Etml();
            // Instancier un objet de lecture.
            StreamReader objFichierALire = new StreamReader(@"..\..\Ressource\About.txt");

            int i = 0;

            // Tant qu'il y a des caractères à lire
            while (!objFichierALire.EndOfStream)
            {
                Console.SetCursorPosition(33, 13 + i);
                // Lire une ligne du fichier.
                string ligneLue = objFichierALire.ReadLine();

                // Afficher la ligne lue sur la console.
                Console.Write(ligneLue);

                i += 3;
            }
            // Fermer le fichier.
            objFichierALire.Close();
            Console.ReadKey();
            MenuGeneral();
        }

        /// <summary>
        /// Musique de l'application
        /// </summary>
        /// <param name="musicOn"></param>
        public void Music(bool musicOn)
        {
            
            var myPlayer = new System.Media.SoundPlayer();

            if (musicOn == true)
            {
                myPlayer.SoundLocation = @"..\..\Ressource\Music1.wav";
                myPlayer.Play();
            }
            else
            {
                myPlayer.Stop();
            }
        }
    }
}
