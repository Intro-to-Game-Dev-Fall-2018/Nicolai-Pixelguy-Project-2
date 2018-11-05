using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpWallDetect : MonoBehaviour {

	private bool IsPlayerUpHitWall = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("UpWall"))
		{
			IsPlayerUpHitWall = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("UpWall"))
		{
			IsPlayerUpHitWall = false;
		}
	}

	public bool upHitWall()
	{
		return IsPlayerUpHitWall;
	}
}
