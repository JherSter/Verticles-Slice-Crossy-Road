using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        SceneManager.LoadScene(" ", LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}