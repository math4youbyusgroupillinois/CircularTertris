 #pragma strict
 
 private var qStart : Quaternion;
 
 function OnMouseDown() {
     var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
     var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
     qStart = Quaternion.Inverse(Quaternion.AngleAxis(angle, Vector3.forward)) * transform.rotation;
 } 
 
 function OnMouseDrag() {
     var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
     var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
     transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward) * qStart;
 }