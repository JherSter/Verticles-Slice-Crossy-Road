using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerDeath : MonoBehaviour {

    public UnityEvent Player_Died;
    public List<string> DeathObjects = new List<string>();
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
        DeathObjects.ForEach(banana => { if (banana == objectName) Die(); } );
    }
    void Die()
    {
        Player_Died.Invoke();
    }
}
