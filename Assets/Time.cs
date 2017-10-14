using UnityEngine;
using System.Collections;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Time : MonoBehaviour
{

	void Start() // Use this for initialization
	{


	}


	// Update is called once per frame
	void Update()
	{

		GetComponent<TextMesh> ().text = System.DateTime.Now.ToString("dddd\nMMMM dd\nyyyy\nhh:mm:ss tt");	


	}


}
