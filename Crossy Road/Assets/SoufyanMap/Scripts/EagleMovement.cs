using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMovement : MonoBehaviour
{
    [SerializeField]private float _moveSpeed;
    [SerializeField]private Transform _playerPosition;
	
	// Update is called once per frame
	void Update()
    {
        Move();
	}

    public void Move()
    {
        //transform.position = new Vector3(transform.position.x -1, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, _playerPosition.position, 0);
    }
}
