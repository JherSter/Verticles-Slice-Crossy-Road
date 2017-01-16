using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour {
    public float duration = 0;
    public float time = 0;
    public bool Enabled = false;
    public bool Repeat = false;
    public UnityEvent timer_Trigger;

    public Timer(float _duration)
    {
        duration = _duration;
    }
	// initialization
	void Start () {
        if (timer_Trigger == null)
        {
            timer_Trigger = new UnityEvent();
        }
        time = duration;
	}
	
	// Update is called once per frame
	void Update () {
		if (enabled)
        {
            if(time == 0)
            {
                timer_Trigger.Invoke();
                if (Repeat)
                {
                    Reset();
                }
            }
            else
            {
                if (time < 0)
                {
                    time = 0;
                }
                else
                {
                    time -= Time.deltaTime;
                }
            }
        }
	}
    // resets the timer time to duration
    public void Reset()
    {
        time = duration;
    }
}
