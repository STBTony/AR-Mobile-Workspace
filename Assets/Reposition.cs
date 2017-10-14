using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour {

	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
			transform.RotateAround (Camera.main.transform.position, Vector3.up, 90);
		}
	}
}
