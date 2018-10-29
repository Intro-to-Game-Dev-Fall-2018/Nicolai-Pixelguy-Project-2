using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownWallDetect : MonoBehaviour {

	private bool DownHitWall = false;

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
			DownHitWall = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Wall"))
		{
			DownHitWall = false;
		}
	}

	public bool downHitWall()
	{
		return DownHitWall;
	}
}
