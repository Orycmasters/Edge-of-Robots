using UnityEngine;
using System.Collections;

public class RobotSys : MonoBehaviour {
	
	public float velocidadeMov;
	public float velocidadeRot;
	
	// Use this for initialization
	void Start () {
		
		velocidadeMov = 5f;
		velocidadeRot = 45f;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButton ("W")) {
			
			transform.Translate(0, 0, velocidadeMov * Time.deltaTime);
			
		}
		
		if (Input.GetButton ("S")) {
			
			transform.Translate(0, 0, -velocidadeMov * Time.deltaTime);
			
		}
		
		if (Input.GetButton ("A")) {
			
			transform.Rotate(0, -velocidadeRot * Time.deltaTime, 0);
			
		}
		
		if (Input.GetButton ("D")) {
			
			transform.Rotate (0, velocidadeRot * Time.deltaTime, 0);
			
		}
	}
}
