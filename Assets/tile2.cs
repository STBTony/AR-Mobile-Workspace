using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		transform.RotateAround (Camera.main.transform.position, Vector3.up, 40);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
