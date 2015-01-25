using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour {
	public float xSpeed = .01f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x + xSpeed, transform.position.y);
	}
}
