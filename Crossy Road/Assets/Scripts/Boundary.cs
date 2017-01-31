using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boundary : MonoBehaviour
{
    public SceneLoader _sceneLoader;


    private void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {





        }
    }
}





