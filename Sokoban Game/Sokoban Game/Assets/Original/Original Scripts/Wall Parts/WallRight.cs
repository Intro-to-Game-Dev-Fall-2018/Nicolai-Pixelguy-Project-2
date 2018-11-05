using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRight : MonoBehaviour
{

	private bool IsBoxNextToRightWall;
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Box"))
		{
			IsBoxNextToRightWall = true;	
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Box"))
		{
			IsBoxNextToRightWall = false;	
		}
	}

	public bool boxRightWall()

	{
		return IsBoxNextToRightWall;
	}
}


