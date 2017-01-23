using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
	public Vector3 gridSize = new Vector3 (1, 1, 1);
    // Scale is  1:10 1:100 1:100
    public int Scale = 1;
    private Node[,,] _grid;

    Grid(Vector3 _gridSize)
    {
        gridSize = _gridSize;

    }
	// Use this for initialization
	void Start () {
	}
    public Vector3 ConvertCordinates(Vector3 cords)
    {
        return new Vector3(Mathf.Abs(cords.x), Mathf.Abs(cords.y), Mathf.Abs(cords.z));
    }
    public Node GetNode(Vector3 cords)
    {
        return _grid[(int)cords.x, (int)cords.y, (int)cords.z];
    }



















    //InvokeRepeating ("UpdatePosition", 1.0,	1.0);
    /*void UpdatePosition(){
		Vector3 newPos = transform.position + movement;
		newPos = Vector3(Mathf.Round(newPos.x/gridSize.x)*gridSize.x,
			Mathf.Round(newPos.y/gridSize.y)*gridSize.y,
			Mathf.Round(newPos.z/gridSize.z)*gridSize.z);
			transform.position = newPos;
	}*/
}
