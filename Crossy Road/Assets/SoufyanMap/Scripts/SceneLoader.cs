using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{

    public void sceneLoad()
    {
        StartCoroutine("WaitTime");
        StartCoroutine("ChangeScene");
    }

    IEnumerator WaitTime()
    {
        SceneManager.LoadScene("testscene");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SoufyanScene");
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
