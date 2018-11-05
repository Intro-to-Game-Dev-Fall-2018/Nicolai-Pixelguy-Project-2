using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownWallDetect : MonoBehaviour {

	private bool IsPlayerDownHitWall = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("DownWall"))
		{
			IsPlayerDownHitWall = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("DownWall"))
		{
			IsPlayerDownHitWall = false;
		}
	}

	public bool downHitWall()
	{
		return IsPlayerDownHitWall;
	}
}
