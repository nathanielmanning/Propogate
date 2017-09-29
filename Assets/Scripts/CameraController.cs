using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	// TODO have this get set somewhere else without breaking.
	void Update () {
		Grid grid = FindObjectOfType<Grid> ();
		GameObject cell = grid.getCells () [grid.width - 1, grid.height - 1];
		float maxHeight = cell.transform.position.y;
		float maxWidth  = cell.transform.position.x;
		transform.position = new Vector3 (maxWidth / 2, maxHeight / 2, -10);
	}
}
