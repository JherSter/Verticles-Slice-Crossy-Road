using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _eagle;

	// Update is called once per frame
	void Awake()
    {
        Spawner();
	}

    public void Spawner()
    {
        Vector3 _spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject e = Instantiate(_eagle, _spawnPos, Quaternion.identity) as GameObject;
    }
}
