using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerDeath : MonoBehaviour {

    public UnityEvent Player_Died;
    public string[] DeathObjects;
	// Use this for initialization
	void Start () {
        if (Player_Died == null)
        {
            Player_Died = new UnityEvent();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        string objectName = collision.transform.tag;
        foreach(string deathObject in DeathObjects)
        {
            if (deathObject == collision.transform.tag)
            {
                Die();
                break;
            }
        }
    }
    void Die()
    {
        Player_Died.Invoke();

    }
}
