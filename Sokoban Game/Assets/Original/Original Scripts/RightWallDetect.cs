using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWallDetect : MonoBehaviour {

	private bool RightHitWall = false;

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
			RightHitWall = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Wall"))
		{
			RightHitWall = false;
		}
	}

	public bool rightHitWall()
	{
		return RightHitWall;
	}
}
