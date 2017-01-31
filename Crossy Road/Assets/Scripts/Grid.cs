using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid {
	public Vector3 gridSize = new Vector3 (1, 1, 1);
    // Scale is  1:10 1:100 1:100
    public int Scale = 1;
    private Node[,,] _grid;

    Grid(Vector3 _gridSize)
    {
        gridSize = _gridSize;
        _grid = new Node[(int)gridSize.x, (int)gridSize.y, (int)gridSize.z];
        for (int y = 0; y < gridSize.y; y++)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                for (int z = 0; z < gridSize.z; z++)
                {
                    _grid[x, y, z] = new Node();
                }
            }
        }

    }
    public Vector3 ConvertCordinates(Vector3 cords)
    {
        return new Vector3(Mathf.Abs(cords.x)/Scale, Mathf.Abs(cords.y), Mathf.Abs(cords.z));
    }
    public Node GetNode(Vector3 cords)
    {
        return _grid[(int)cords.x, (int)cords.y, (int)cords.z];
    }
    // Im aware this is not single responsibility but time is short
    // This functions scrolls the array down by 1 and deletes the lower row
    public void Scroll()
    {
        Node[,,] temp = _grid;
        for (int y = 0; y < gridSize.y-1; y++)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                for (int z = 0; z < gridSize.z; z++)
                {
                    
                    temp[x, y+1, z] = _grid[x,y,z];

                }
            }
        }
    }
}
