using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 25;
	// Update is called once per frame
	void Update ()
    {
        Forward();
        Left();
        Right();
        Backward();
	}

    void Forward()
	{
		if (Input.GetKeyDown (KeyCode.W))
        {	
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 1);
            transform.rotation = Quaternion.AngleAxis(0, -Vector3.up);
		}
	}

    void Left()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
			transform.position = new Vector3 (transform.position.x - 1, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
		}
    }

    void Right()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
			transform.position = new Vector3 (transform.position.x + 1, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
    }

    void Backward()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }
    }


}
