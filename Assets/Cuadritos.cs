using UnityEngine;
using System.Collections;

public class Cuadritos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	bool isValidGridPos() {        
		foreach (Transform child in transform) {
			Vector2 v = Cuadrito.roundVec2(child.position);
			
			// Not inside Border?
			if (!Cuadrito.insideBorder(v))
				return false;
			
			// Block in grid cell (and not part of same group)?
			if (Cuadrito.grid[(int)v.x, (int)v.y] != null &&
			    Cuadrito.grid[(int)v.x, (int)v.y].parent != transform)
				return false;
		}
		return true;
	}
}
