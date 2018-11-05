using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallDetect : MonoBehaviour {

	private bool isPlayerLeftHitWall = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("LeftWall"))
		{
			isPlayerLeftHitWall = true;	
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("LeftWall"))
		{
			isPlayerLeftHitWall = false;	
		}
	}

	public bool leftHitWall()
	{
		return isPlayerLeftHitWall;
	}
}

