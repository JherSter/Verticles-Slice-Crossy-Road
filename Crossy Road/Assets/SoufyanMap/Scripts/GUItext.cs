using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUItext : MonoBehaviour
{
    Counter _counter = new Counter();
    private GUIText _guiText;

	// Use this for initialization
	void Start ()
    {
        _guiText = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        _guiText.text = " " + _counter.GetCount();
        _counter.Increase();
	}
}
