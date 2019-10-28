using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 1);
            string s = @"                                                                                                                            
       ^
       !
       !
      / \
     /___\
    |=   =|
    |     |
    |     |
    |     |
    |     |
    |     |
    |     |
    |     |
    |     |
    |     |
   /|█████|\
  / |█████| \
 /  |█████|  \
|  / ^ | ^ \  |
| /  ( | )  \ |
|/   ( | )   \|
    ((   ))
   ((  :  ))
   ((  :  ))
    ((   ))
     (( ))
      ( )
       .
       .
       .";


            for (int i = 50; i > -32; --i)
            {
                Console.Clear();
                for (int j = 0; j < s.Split('\n').Length; ++j)
                {
                    try
                    {
                        Console.SetCursorPosition((System.Console.WindowWidth / 2), j + i);
                        Console.Write(s.Split('\n')[j]);
                    }
                    catch
                    {

                    }
                    
                }
                Thread.Sleep(10);
            }
            Console.ReadLine();
        }
    }
}
