using UnityEngine;
using System.Collections;


public class ArrayRenderer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		SetColor ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SetColor(){

		GameObject[] blueCube = GameObject.FindGameObjectsWithTag("Blue");
		GameObject[] redCube = GameObject.FindGameObjectsWithTag("Red");

		foreach (GameObject newBlueCube in blueCube) {
				
			newBlueCube.renderer.material.color = Color.blue;

		}
		foreach (GameObject newRedCube in redCube) {
			
			newRedCube.renderer.material.color = Color.red;
			
		}
	}
}
