using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChangeUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("LeftPlayer"))
		{
			
			
		}

		if (other.gameObject.CompareTag("RightPlayer"))
		{
			
		}

		if (other.gameObject.CompareTag("UpPlayer"))
		{
			
		}

		
		if (other.gameObject.CompareTag("DownPlayer") && (other.gameObject.CompareTag("DownWall")))
		{
			
		}
		else if (other.gameObject.CompareTag("DownPlayer"))
		{
			
		}
	}
}
