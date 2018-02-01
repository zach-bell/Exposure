using UnityEngine;

namespace Core.Structures.Maze
{
    public class MazeCell
    {
        public bool Visited = false;
        public GameObject NorthWall, SouthWall, EastWall, WestWall, Floor;
    }
}