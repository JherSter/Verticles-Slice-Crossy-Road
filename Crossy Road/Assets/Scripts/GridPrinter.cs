using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPrinter : MonoBehaviour {

    public Grid _grid;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void printGrid(Grid _grid)
    {
        string printingString = "";
        for (int y = 0; y < _grid.gridSize.y; y++)
        {
            printingString = printingString + "/n";

            for (int x = 0; x < _grid.gridSize.x; x++)
            {
                for (int z = 0; z < _grid.gridSize.z; z++)
                {

                }
            }
        }
    }
}
