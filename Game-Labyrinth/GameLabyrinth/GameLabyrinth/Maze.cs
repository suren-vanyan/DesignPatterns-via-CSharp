using System;
using System.Collections.Generic;
using System.Text;

namespace GameLabyrinth
{
    class Maze
    {
        private Dictionary<int, Room> _rooms=null;
        public Maze()
        {
            _rooms = new Dictionary<int, Room>();
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room.RoomNumber, room);
        }

        public Room RoomNo(int number)
        {
            return _rooms[number];
        }
    }
}
