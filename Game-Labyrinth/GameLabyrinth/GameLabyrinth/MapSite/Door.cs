using System;
using System.Collections.Generic;
using System.Text;

namespace GameLabyrinth
{
    class Door : MapSite
    {
        private Room _room1;
        private Room _room2;
        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public override void Enter()
        {
            Console.WriteLine("Door");
        }

        public Room OtherSideOpen(Room room)
        {
            if (room == _room1)
            { return _room2; }
            return _room1;
        }
    }
}
