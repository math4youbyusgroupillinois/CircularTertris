using UnityEngine;
using System.Collections;

public class RotateWithMouse : MonoBehaviour {

	public float clicksPer360 = 12;
	private float snapDegreesAtEvery;
	private Quaternion qStart;
	private float prevSnappedAngle;

	void Start(){
		snapDegreesAtEvery = 360/clicksPer360;
		prevSnappedAngle = 0;
	}
	
	void OnMouseDown() {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		qStart = Quaternion.Inverse(Quaternion.AngleAxis(calculateSnap(angle), Vector3.forward)) * transform.rotation;
	} 
	
	void OnMouseDrag() {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		float snappedAngle = calculateSnap (angle);
		transform.rotation = Quaternion.AngleAxis(snappedAngle, Vector3.forward) * qStart;

		if (prevSnappedAngle != snappedAngle) {
			float difference = snappedAngle - prevSnappedAngle;

			if ( prevSnappedAngle < 0 && snappedAngle == 180-snapDegreesAtEvery) Debug.Log("Fixed right");
			else if (prevSnappedAngle > 0 && snappedAngle == -180) Debug.Log("Fixed Left");
			else if ( difference < 0) Debug.Log("right");
			else Debug.Log("left");

			Debug.Log("Snapped angle = " + snappedAngle);
			prevSnappedAngle = snappedAngle;
		}
	}

	float calculateSnap(float angle){
		return Mathf.Floor(angle/snapDegreesAtEvery)*snapDegreesAtEvery;
	}
}