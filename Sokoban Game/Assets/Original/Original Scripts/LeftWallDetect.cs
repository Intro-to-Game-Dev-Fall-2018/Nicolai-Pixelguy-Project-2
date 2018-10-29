using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallDetect : MonoBehaviour {

	private bool LeftHitWall = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Wall"))
		{
			LeftHitWall = true;	
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Wall"))
		{
			LeftHitWall = false;	
		}
	}

	public bool leftHitWall()
	{
		return LeftHitWall;
	}
}

