using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField]
    public GameObject  Player;
	private Vector3 _shouldpos;
    private Vector3 _camera;




    private void Start (){

	}


    private void Update(){
		_shouldpos = Vector3.Lerp (gameObject.transform.position, Player.transform.position, Time.deltaTime);

       transform.position = new Vector3(_shouldpos.x,8,_camera.z += 0.02f);

        }
    }
