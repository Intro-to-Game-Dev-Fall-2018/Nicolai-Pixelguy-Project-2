using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSensorLeft : MonoBehaviour {

	private bool IsBoxLeftHitWall;
	private bool IsBoxLeftHitBox;

	// Use this for initialization
	void Start()
	{
		IsBoxLeftHitBox = false;
		IsBoxLeftHitWall = false;
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("DownWall"))
		{
			IsBoxLeftHitWall = true;
		}

		if (other.gameObject.CompareTag("Box Up"))
		{
			IsBoxLeftHitBox = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("DownWall"))
		{
			IsBoxLeftHitWall = false;
		}

		if (other.gameObject.CompareTag("Box Up"))
		{
			IsBoxLeftHitBox = false;
		}
	}

	public bool BoxLeftHitWall()
	{
		return IsBoxLeftHitWall;
	}

	public bool BoxLeftHitBox()
	{
		return IsBoxLeftHitBox;
	}
}


