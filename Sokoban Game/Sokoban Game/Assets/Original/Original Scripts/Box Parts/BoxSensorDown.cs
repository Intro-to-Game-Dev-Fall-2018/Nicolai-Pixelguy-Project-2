using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BoxSensorDown : MonoBehaviour
{

	private bool IsBoxDownHitWall;
	private bool IsBoxDownHitBox;

	// Use this for initialization
	void Start()
	{
		IsBoxDownHitBox = false;
		IsBoxDownHitWall = false;
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("DownWall"))
		{
			IsBoxDownHitWall = true;
		}

		if (other.gameObject.CompareTag("Box Up"))
		{
			IsBoxDownHitBox = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("DownWall"))
		{
			IsBoxDownHitWall = false;
		}

		if (other.gameObject.CompareTag("Box Up"))
		{
			IsBoxDownHitBox = false;
		}
	}

	public bool BoxDownHitWall()
	{
		return IsBoxDownHitWall;
	}

	public bool BoxDownHitBox()
	{
		return IsBoxDownHitBox;
	}
}

