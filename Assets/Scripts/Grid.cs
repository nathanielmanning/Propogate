using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Represents a grid of triangular cells
 * 
 * Author -- Evan S.
 */
public class Grid : MonoBehaviour {

	// Width of the grid. Should generally be 2x the height of the grid
	public int width;
	// Height of the grid.
	public int height;

	// Game object that represents our cell type.
	public GameObject celltype;

	private GameObject[,] cells;

	/**
	 * Mostly just initialize the cells
	 */
	void Start () {
		initGrid ();
	}

	/**
	 * Initialize the Grid of Cells
	 */
	void initGrid() {
		cells = new GameObject[width, height];
		float heightOffset = 1-(Mathf.Sqrt(3)/2);
		for (int i = 0; i < width; i++) {
			for (int j = 0; j < height; j++) {
				GameObject newCell = Instantiate(celltype, new Vector3(i/2.0f,j-(j*heightOffset),0), Quaternion.identity,
					gameObject.transform);
				if ((i + j) % 2 != 0) {
					newCell.transform.Rotate (new Vector3 (0, 0, 180));
					// Ratio of width of the asset to the height
					//newCell.transform.position += new Vector3(0, heightOffset, 0);
				}
				cells [i, j] = newCell;
				cells [i, j].SetActive (false);
			}
		}
	}

	public GameObject[,] getCells() {
		return cells;
	}
}
