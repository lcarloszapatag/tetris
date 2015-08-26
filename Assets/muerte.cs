using UnityEngine;
using System.Collections;

public class muerte : MonoBehaviour {

	// Use this for initialization
	void Start () {
	if (transform.position.y <= 30) {

			dead();
		}


	}

	void dead(){
		Application.LoadLevel("Game over");


	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
