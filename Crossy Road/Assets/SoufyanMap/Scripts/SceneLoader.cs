﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void SceneLoad()
    {
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("LoadingScene");
        StartCoroutine("MainScene");
    }

    IEnumerator MainScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SoufyanScene");
    }
}
