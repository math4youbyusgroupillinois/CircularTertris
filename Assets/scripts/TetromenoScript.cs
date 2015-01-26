using UnityEngine;
using System.Collections.Generic;

public class TetriminoScript : MonoBehaviour {

	public GameObject blockPrefab;
	public List <GameObject> blocks = new List<GameObject>();

	void Start () {
		//call random tetrimino
		
		GameObject newBlock = (Instantiate (blockPrefab, new Vector3 (0,0,0), Quaternion.identity)) as GameObject;
		blocks.Add (newBlock);

	}
}