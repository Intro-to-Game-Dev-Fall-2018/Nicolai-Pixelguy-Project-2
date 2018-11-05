using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class EndGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if((other.gameObject.CompareTag("Box 1")) && 
		(other.gameObject.CompareTag("Box 2")) && 
			(other.gameObject.CompareTag("Box 3")))
		{
			Application.LoadLevel("Title Screen");
		}
	}
}
