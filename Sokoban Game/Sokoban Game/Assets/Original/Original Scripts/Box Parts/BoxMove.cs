using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour {

	[SerializeField] private float distanceToMove;
	[SerializeField] private float moveSpeed;
	private bool moveToPoint = false;
	private Vector3 endPosition;

	
	
	void Start ()
	{
		
	}
	
	
	void Update ()
	{
		//Debug.Log(touchPlayer);
	}
	
	void FixedUpdate () {

		if (moveToPoint)
		{
			transform.position = Vector3.MoveTowards(transform.position, endPosition, moveSpeed * Time.deltaTime);
		}
		

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("LeftPlayer"))
		{
			endPosition = new Vector3(endPosition.x - distanceToMove, endPosition.y, endPosition.z);
			moveToPoint = true;
			
		}
		

		if (other.gameObject.CompareTag("RightPlayer"))
		{
			endPosition = new Vector3(endPosition.x + distanceToMove, endPosition.y, endPosition.z);
			moveToPoint = true;
			
		}
		

		if (other.gameObject.CompareTag("UpPlayer"))
		{
			endPosition = new Vector3(endPosition.x, endPosition.y + distanceToMove, endPosition.z);
			moveToPoint = true;
			
		}

		
		if (other.gameObject.CompareTag("DownPlayer"))
		{
			endPosition = new Vector3(endPosition.x, endPosition.y - distanceToMove, endPosition.z);
			moveToPoint = true;
			
		}
	}
}
