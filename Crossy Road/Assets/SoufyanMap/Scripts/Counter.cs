using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _count = 0;
    private bool _playerForward = false;
    [SerializeField] private GameObject _player;
    private GUIText _guiText;

	// Use this for initialization
	void Start ()
    {
        _guiText = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Increase();
	}

    void Increase()
    {
        _guiText.text = " " + _count;

        if (Input.GetKeyDown(KeyCode.W))
        {
            _count++;
            _playerForward = true;
        }
    }

    void Decrease()
    {

    }

    void Add(int _temp)
    {
        
    }

    void Reset()
    {

    }

    void Set(int _temp)
    {

    }

    void GetCount()
    {

    }
}
