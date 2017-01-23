using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    public PlayerMovement Movement;
    public bool Enabled = true;
    public bool WaitBetweenMovement = true;
    public float WaitTime = 1;
    Timer timer;
    
	// Update is called once per frame
	void Update () {
        if (Enabled)
        {
            if (Input.GetAxisRaw("W") == 1)
            {
                Movement.Forward();
                if (WaitBetweenMovement)
                {
                    Wait();
                }
            }
            if (Input.GetAxisRaw("S") == 1)
            {
                Movement.Left();
                if (WaitBetweenMovement)
                {
                    Wait();
                }
            }
            if (Input.GetAxisRaw("A") == 1)
            {
                Movement.Right();
                if (WaitBetweenMovement)
                {
                    Wait();
                }
            }
            if (Input.GetAxisRaw("D") == 1)
            {
                Movement.Backward();
                if (WaitBetweenMovement)
                {
                    Wait();
                }
            }
        }
    }
    //Enables the input
    void Enable()
    {
        Enabled = true;
    }
    // Waits the amount of time WaitTime has
    void Wait()
    {
        Enabled = false;
        timer = new Timer(WaitTime);
        timer.timer_Trigger.AddListener(Enable);
        timer.Enabled = true;
    }
}
