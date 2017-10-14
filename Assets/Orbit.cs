using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {
	float speed = 10;
	void Start() {
		speed = 50 * Random.Range(-1.0f, 1.0f);
		transform.RotateAround (Camera.main.transform.position, Vector3.up, speed);
	}
	// Update is called once per frame
	void Update () {
		//transform.RotateAround (Camera.main.transform.position, Vector3.up, speed * Time.deltaTime);
	}
}
