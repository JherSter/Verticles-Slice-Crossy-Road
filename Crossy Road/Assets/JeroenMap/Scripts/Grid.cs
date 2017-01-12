using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
	private Vector3 gridSize = new Vector3 (1, 1, 1);
	private Vector3 movement = new Vector3 (0, 0, 1);

	// Use this for initialization
	void Start () {
		//InvokeRepeating ("UpdatePosition", 1.0,	1.0);
		
	}
	
	void UpdatePosition(){
		Vector3 newPos = transform.position + movement;
		newPos = Vector3(Mathf.Round(newPos.x/gridSize.x)*gridSize.x,
			Mathf.Round(newPos.y/gridSize.y)*gridSize.y,
			Mathf.Round(newPos.z/gridSize.z)*gridSize.z);
			transform.position = newPos;
	}
}
