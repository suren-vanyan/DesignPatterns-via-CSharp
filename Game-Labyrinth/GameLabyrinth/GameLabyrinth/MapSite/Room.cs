using System;
using System.Collections.Generic;
using System.Text;

namespace GameLabyrinth
{
    class Room : MapSite
    {
        private int _roomNumber;
        private Dictionary<Direction, MapSite> _sides;

        public Room(int roomNumber)
        {
            this._roomNumber = roomNumber;
            _sides = new Dictionary<Direction, MapSite>(4);
        }

        public int RoomNumber { get => _roomNumber; set => _roomNumber = value; }

        public void SetSide(Direction direction,MapSite mapSite)
        {
            _sides.Add(direction, mapSite);
        }

        public MapSite GetSide(Direction direction) => _sides[direction];
       
        public override void Enter()
        {
            Console.WriteLine("Room");
        }
    }
}
