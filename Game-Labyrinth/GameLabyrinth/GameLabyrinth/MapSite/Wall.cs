using System;
using System.Collections.Generic;
using System.Text;

namespace GameLabyrinth
{
    class Wall : MapSite
    {
        public Wall()
        {           
        }
        public override void Enter()
        {
            Console.WriteLine("There is a wall");
        }
    }
}
