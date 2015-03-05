using UnityEngine;
using System.Collections;

public class ThirdPersonView : MonoBehaviour {


	public Transform CameraPos;
	public Transform Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Slerp (transform.position, CameraPos.position, Time.deltaTime);
		transform.LookAt (Player);
	
	}
}
