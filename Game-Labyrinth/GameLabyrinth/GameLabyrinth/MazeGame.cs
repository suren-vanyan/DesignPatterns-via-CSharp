using System;
using System.Collections.Generic;
using System.Text;

namespace GameLabyrinth
{
    class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze aMaze = new Maze();
            Room room1 = new Room(1);
            Room room2 = new Room(2);
            Door theDoor = new Door(room1, room2);
            aMaze.AddRoom(room1);
            aMaze.AddRoom(room2);
            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.East, theDoor);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());
            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.West, theDoor);
            return aMaze;
        }


    }
}
