using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{

    public void sceneLoad()
    {
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
        //Invoke("MainScene", 2);
        StartCoroutine("MainScene");
        //Debug.Log("test");
    }

    IEnumerator MainScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
        //Debug.Log("SoufyanScene");
    }
}
