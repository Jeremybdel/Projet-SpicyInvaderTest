using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSpicyVader
{
    class EnemyB : Enemy
    {
        public EnemyB(int _positionX, int _positionY)
        {
            positionX = _positionX;
            positionY = _positionY;

            sizeX = 10;
            sizeY = 6;

            sprite = (@"
 ▄▄████▄▄   
██████████  
██▄▄██▄▄██  
 ▄▀▄▀▀▄▀▄   
▀        ▀  
            ");
        }


    }
}
