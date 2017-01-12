using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour {
    public float duration = 0;
    public float time;
    public bool Enabled = false;
    UnityEvent timer_Trigger;

    Timer(float _duration)
    {
        duration = _duration;
    }
	// Use this for initialization
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
            
            if (time< 0)
            {
                time = 0;
            }
            else
            {
                time -= Time.deltaTime;
            }
            
        }
	}
    public void Reset()
    {
        time = duration;
    }
}
