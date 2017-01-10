using System.Collections;
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

    void Forward()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            //player beweegt naar voren, z axis wordt met 1 verhoogd
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
        }
    }

    void Left()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            //player beweegt naar links, x axis wordt met 1 verlaagd
            transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        }
    }

    void Right()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            //player beweegt naar rechts, x axis wordt met 1 verhoogd
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
    }

    void Backward()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //player beweegt naar achter, z axis wordt met 1 verlaagd
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
        }
    }
}
