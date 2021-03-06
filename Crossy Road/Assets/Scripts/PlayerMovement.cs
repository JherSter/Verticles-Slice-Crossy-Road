﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Update is called once per frame

    void Update ()
    {
        Forward();
        Left();
        Right();
        Backward();
	}

    public void Forward()
	{
		if (Input.GetKeyDown (KeyCode.S))
        {	
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 5);
            transform.rotation = Quaternion.AngleAxis(0, -Vector3.up);

		}
	}

    public void Left()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
			transform.position = new Vector3 (transform.position.x - 5, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
		}
    }

    public void Right()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
			transform.position = new Vector3 (transform.position.x + 5, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
    }

    public void Backward()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 5);
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }
    }
}
