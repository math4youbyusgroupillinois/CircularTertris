//square 
using UnityEngine;
using System.Collections.Generic;

public class Tet1Script : MonoBehaviour {
	
	public GameObject blockPrefab;
	public List <GameObject> blocks = new List<GameObject>();
	
	void Start () {
		/*
		GameObject newBlock1 = (Instantiate (blockPrefab, transform.position + new Vector3 (0,0), Quaternion.identity)) as GameObject;
		newBlock1.transform.parent = transform;
		blocks.Add (newBlock1);
		GameObject newBlock2 = (Instantiate (blockPrefab, transform.position + new Vector3 (0,-1), Quaternion.identity)) as GameObject;
		newBlock2.transform.parent = transform;
		blocks.Add (newBlock2);
		GameObject newBlock3 = (Instantiate (blockPrefab, transform.position + new Vector3 (1,0), Quaternion.identity)) as GameObject;
		newBlock3.transform.parent = transform;
		blocks.Add (newBlock3);
		GameObject newBlock4 = (Instantiate (blockPrefab, transform.position + new Vector3 (1,-1), Quaternion.identity)) as GameObject;
		newBlock4.transform.parent = transform;
		blocks.Add (newBlock4);
		*/
	}
}