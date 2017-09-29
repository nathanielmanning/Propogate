using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

	public int width;
	public int height;

	public GameObject celltype;

	public GameObject[,] cells;

	// Use this for initialization
	void Start () {
		cells = new GameObject[width, height];
		initGrid ();
	}

	void initGrid() {
		float heightOffset = 1-(Mathf.Sqrt(3)/2);
		for (int i = 0; i < width; i++) {
			for (int j = 0; j < height; j++) {
				GameObject newCell = Instantiate(celltype, new Vector3(i,j+heightOffset,0), Quaternion.identity,
					gameObject.transform);
				if ((i + j) % 2 != 0) {
					newCell.transform.Rotate (new Vector3 (0, 0, 180));
					// Ratio of width of the asset to the height
					newCell.transform.position += new Vector3(0, heightOffset, 0);
				}
				cells [i, j] = newCell;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
