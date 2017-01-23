using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour {
    public Vector3 Direction;
    public float speed;
    private Vector3 Vector;
    private Rigidbody Body;
	// Use this for initialization
	void Start () {
        Body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector = Direction.normalized * Time.deltaTime * speed;
        Body.velocity = Vector;
        Debug.Log(Vector);
	}
    void DestroyObstacle()
    {
        DestroyImmediate(this);
    }
}
