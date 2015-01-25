//square 
using UnityEngine;
using System.Collections.Generic;

public class Tet1Script : MonoBehaviour {
	
	public GameObject blockPrefab;
	public List <GameObject> blocks = new List<GameObject>();
	
	void Start () {
		
		GameObject newBlock1 = (Instantiate (blockPrefab, new Vector2 (0,0), Quaternion.identity)) as GameObject;
		blocks.Add (newBlock1);
		GameObject newBlock2 = (Instantiate (blockPrefab, new Vector2 (0,-1), Quaternion.identity)) as GameObject;
		blocks.Add (newBlock2);
		GameObject newBlock3 = (Instantiate (blockPrefab, new Vector2 (1,0), Quaternion.identity)) as GameObject;
		blocks.Add (newBlock3);
		GameObject newBlock4 = (Instantiate (blockPrefab, new Vector2 (1,-1), Quaternion.identity)) as GameObject;
		blocks.Add (newBlock4);
		
	}
}