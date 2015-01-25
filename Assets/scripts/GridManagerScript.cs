using UnityEngine;
using System.Collections.Generic;

public class GridManagerScript : MonoBehaviour {
	
	public GameObject squareTet, lineTet, hillTet, 
	rightLTet, backwardLTet, rightZTet, backwardZTet;


	GameObject [][] grid = new GameObject[24][];
	public List <GameObject> sandbox = new List<GameObject>();
	//make tetriminoCatalog array of possible tetriminos 
	public List <GameObject> tetCatalog = new List<GameObject>();

	//instantiate

	void Start() {

		tetCatalog.Add(squareTet);
		tetCatalog.Add(lineTet);
		tetCatalog.Add(hillTet);
		tetCatalog.Add(rightLTet);
		tetCatalog.Add(backwardLTet);
		tetCatalog.Add(rightZTet);
		tetCatalog.Add(backwardZTet);

		// every 5 seconds, make a new tetrimino 
		InvokeRepeating("SpawnTetrimino",0, 5.0f);
	}

	void Update() {
		// checking for completed rows
		// every second each block moves down 1 unit
	}

	private void SpawnTetrimino() {
		//instantiate the randomly selected prefab
		GameObject randomTetrimino = getRandomTet ();
		Instantiate (randomTetrimino, Vector3.zero, Quaternion.identity);
	}

	//a getRandomTet funciton that returns a random prefab(tet)
	private GameObject getRandomTet() {
		return tetCatalog[Random.Range(0, tetCatalog.Count - 1)];
	}

	private int getRandomInt (int upperBound) {
		return Random.Range(0, upperBound);		
	}

}