using UnityEngine;
using System.Collections;

public class tetris : MonoBehaviour {

	public GameObject[] groups;

	//sale aleatoriamante la figura de tetris

	public void aleatoria_tetris(){

		int i = Random.Range(0, groups.Length);
		
		// Spawn Group at current Position
		Instantiate(groups[i],
		            transform.position,
		            Quaternion.identity);

	}


	// Use this for initialization
	void Start () {
	
		aleatoria_tetris ();

	}
	
	// Update is called once per frame
	 void Update () {
	
	}
}
