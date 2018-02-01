using Core.Contracts.Maze;
using Core.Structures;
using Core.Structures.Maze;
using Core.Utilities.Maze;
using UnityEngine;

namespace UnityScripts.Maze
{
    public class MazeManager : MonoBehaviour
    {
        public int mazeRows, mazeColumns;
        public GameObject wall; 
        public GameObject floor;
        public float size = 2f;
        public Difficulty Difficulty;

        // Use this for initialization
        void Awake()
        {
            MazeCell[,] unbuiltMaze = BuildMazeGrid();

            MazeAlgorithmBase ma = new MazeAlgorithm(unbuiltMaze, this.Difficulty);
            ma.CreateMaze();
        }

        private MazeCell[,] BuildMazeGrid()
        {
            MazeCell[,] mazeCells = new MazeCell[mazeRows, mazeColumns];

            for (int currentRow = 0; currentRow < mazeRows; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < mazeColumns; currentColumn++)
                {
                    mazeCells[currentRow, currentColumn] = new MazeCell();

                    mazeCells[currentRow, currentColumn].Floor =
                        Instantiate(floor, new Vector3(currentRow * size, -(size / 2f), currentColumn * size),
                            Quaternion.identity) as GameObject;
                    mazeCells[currentRow, currentColumn].Floor.name = "Floor " + currentRow + "," + currentColumn;
                    //mazeCells [r, c] .floor.transform.Rotate (Vector3.right, 90f);

                    if (currentColumn == 0)
                    {
                        mazeCells[currentRow, currentColumn].WestWall =
                            Instantiate(wall, new Vector3(currentRow * size, 0, (currentColumn * size) - (size / 2f)),
                                Quaternion.identity) as GameObject;
                        mazeCells[currentRow, currentColumn].WestWall.name = "West Wall " + currentRow + "," + currentColumn;
                    }

                    mazeCells[currentRow, currentColumn].EastWall =
                        Instantiate(wall, new Vector3(currentRow * size, 0, (currentColumn * size) + (size / 2f)),
                            Quaternion.identity) as GameObject;
                    mazeCells[currentRow, currentColumn].EastWall.name = "East Wall " + currentRow + "," + currentColumn;

                    if (currentRow == 0)
                    {
                        mazeCells[currentRow, currentColumn].NorthWall =
                            Instantiate(wall, new Vector3((currentRow * size) - (size / 2f), 0, currentColumn * size),
                                Quaternion.identity) as GameObject;
                        mazeCells[currentRow, currentColumn].NorthWall.name = "North Wall " + currentRow + "," + currentColumn;
                        mazeCells[currentRow, currentColumn].NorthWall.transform.Rotate(Vector3.up * 90f);
                    }

                    mazeCells[currentRow, currentColumn].SouthWall =
                        Instantiate(wall, new Vector3((currentRow * size) + (size / 2f), 0, currentColumn * size),
                            Quaternion.identity) as GameObject;
                    mazeCells[currentRow, currentColumn].SouthWall.name = "South Wall " + currentRow + "," + currentColumn;
                    mazeCells[currentRow, currentColumn].SouthWall.transform.Rotate(Vector3.up * 90f);
                }
            }

            return mazeCells;
        }
    }
}