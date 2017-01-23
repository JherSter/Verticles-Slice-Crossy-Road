using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _count = 0;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        Increase();
	}

    public void Increase()
    {
        _count++;
    }

    public void Decrease()
    {

    }

    public void Add(int _temp)
    {
        
    }

    public void Reset()
    {

    }

    public void Set(int _temp)
    {

    }

    public int GetCount()
    {
        return _count;
    }
}
