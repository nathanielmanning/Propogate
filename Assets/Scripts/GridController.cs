using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Manipulates the grid of triangles with user input.
 */
public class GridController : MonoBehaviour {

	// Points to a position in the grid.
	Point pointer;

	Grid grid;

	// Use this for initialization
	void Start () {
		pointer = new Point (0, 0);
		grid = FindObjectOfType<Grid> ();
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			grid.getCells()[pointer.x,pointer.y].GetComponent<SpriteRenderer> ().color = Color.white;
			pointer.x = Mathf.Max(0,pointer.x-1);
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			grid.getCells()[pointer.x,pointer.y].GetComponent<SpriteRenderer> ().color = Color.white;
			pointer.x = Mathf.Min(grid.width-1,pointer.x+1);
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			grid.getCells()[pointer.x,pointer.y].GetComponent<SpriteRenderer> ().color = Color.white;
			pointer.y = Mathf.Min(grid.height-1,pointer.y+1);
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			grid.getCells()[pointer.x,pointer.y].GetComponent<SpriteRenderer> ().color = Color.white;
			pointer.y = Mathf.Max(0,pointer.y-1);
		}

		grid.getCells () [pointer.x, pointer.y].GetComponent<SpriteRenderer> ().color = Color.red;
		if (!grid.getCells()[pointer.x,pointer.y].activeSelf) {
			grid.getCells () [pointer.x, pointer.y].SetActive (true);
		}
	}
	
}
