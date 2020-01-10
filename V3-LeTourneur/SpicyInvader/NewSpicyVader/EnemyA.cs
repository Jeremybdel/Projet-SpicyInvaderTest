using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpicyVader
{
    class EnemyA:Enemy
    {
        public EnemyA(int _positionX, int _positionY)
        {
            positionX = _positionX;
            positionY = _positionY;

            sizeX = 10;
            sizeY = 6;

            sprite = (@"
   ▄██▄     
 ▄██████▄   
███▄██▄███  
  ▄▀▄▄▀▄    
 ▀ ▀  ▀ ▀   
            ");
        }


    }
}
