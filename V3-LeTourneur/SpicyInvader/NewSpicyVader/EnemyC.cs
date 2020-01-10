using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpicyVader
{
    class EnemyC : Enemy
    {
        public EnemyC(int _positionX, int _positionY)
        {
            positionX = _positionX;
            positionY = _positionY;

            sizeX = 11;
            sizeY = 6;

            sprite = (@"
  ▀▄   ▄▀   
 ▄█▀███▀█▄  
█▀███████▀█ 
█ █▀▀▀▀▀█ █ 
   ▀▀ ▀▀    
            ");
        }


    }
}

