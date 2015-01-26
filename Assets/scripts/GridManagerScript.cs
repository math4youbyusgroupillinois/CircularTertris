using UnityEngine;
using System.Collections.Generic;

public class GridManagerScript : MonoBehaviour {
	
	public GameObject squareTet, lineTet, hillTet, 
	rightLTet, backwardLTet, rightZTet, backwardZTet;


	GameObject [][] grid = new GameObject[12][];
	public List <GameObject> sandbox = new List<GameObject>();
	//make tetriminoCatalog array of possible tetriminos 
	public List <GameObject> tetCatalog = new List<GameObject>();

	private int snapsPer360 = 12;
	private int heightOfWorld = 5;

	void Start() {
		//add all types of tetrimenos to the catalog
		tetCatalog.Add(squareTet);
		tetCatalog.Add(lineTet);
		tetCatalog.Add(hillTet);
		tetCatalog.Add(rightLTet);
		tetCatalog.Add(backwardLTet);
		tetCatalog.Add(rightZTet);
		tetCatalog.Add(backwardZTet);

		// every 5 seconds, make a new tetrimino 
		InvokeRepeating("SpawnTetrimino",0, 0.5f);
	}

	void Update() {
		// checking for completed rows
		// every second each block moves down 1 unit
	}

	private void SpawnTetrimino() {
		//instantiate the randomly selected prefab
		GameObject randomTetrimino = getRandomTet ();
		Transform randomTransform = getRandomSpawnTransform ();
		Instantiate (randomTetrimino, randomTransform.position, randomTransform.rotation);
		//ßsandbox.Add (newTetrimeno);
	}

	//a getRandomTet funciton that returns a random prefab(tet)
	private GameObject getRandomTet() {
		return tetCatalog[Random.Range(0, tetCatalog.Count - 1)];
	//	return tetCatalog [1];
	}

	private int getRandomInt (int upperBound) {
		return Random.Range(0, upperBound);		
	}

	private Transform getRandomSpawnTransform(){
		Transform dummyTransform = new GameObject().transform;
		dummyTransform.position = Vector3.zero + new Vector3(0, heightOfWorld, 0); //lift the object up
		dummyTransform.RotateAround(Vector3.zero, Vector3.forward, getRandomSnappedAngle() );   //rotate it around the world
		Debug.Log ("spawned new tetrimeno at " + dummyTransform.position.x + ", " + dummyTransform.position.y);
		return dummyTransform;
	}
	private float getRandomSnappedAngle (){
		return getSnappedAngle( Random.Range(0, 360), snapsPer360);
	}

    private float getSnappedAngle( float angle, float snapAtEveryNumDegrees){
		Debug.Log("Making a random snapped angle " + Mathf.Floor (angle / snapAtEveryNumDegrees) * snapAtEveryNumDegrees);
		return Mathf.Floor (angle / snapAtEveryNumDegrees) * snapAtEveryNumDegrees;
	}
}