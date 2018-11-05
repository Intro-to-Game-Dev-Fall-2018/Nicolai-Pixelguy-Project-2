using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Analytics;

// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
public class TileMovementController : MonoBehaviour {
	[SerializeField] private float distanceToMove;
	[SerializeField] private float moveSpeed;
	private bool moveToPoint = false;
	private Vector3 endPosition;

	public GameObject LeftWallFeel;
	public GameObject RightWallFeel;
	public GameObject UpWallFeel;
	public GameObject DownWallFeel;
	
	private LeftWallDetect LeftWallScript;
	private RightWallDetect RightWallScript;
	private UpWallDetect UpWallScript;
	private DownWallDetect DownWallScript;

	public GameObject Box;

	private BoxMove Box1;
	private BoxMove TouchingPlayer;
	
	void Start () {
		endPosition = transform.position;
		
		LeftWallScript = LeftWallFeel.GetComponent<LeftWallDetect>();
        RightWallScript = RightWallFeel.GetComponent<RightWallDetect>();
        UpWallScript = UpWallFeel.GetComponent<UpWallDetect>();
        DownWallScript = DownWallFeel.GetComponent<DownWallDetect>();
		
		Box1 = Box.GetComponent<BoxMove>();

	}
  
	void FixedUpdate () {
		if (moveToPoint)
		{
			transform.position = Vector3.MoveTowards(transform.position, endPosition, moveSpeed * Time.deltaTime);
		}
	}


	void Update()
	{

		if (Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		
		Box1 = Box.GetComponent<BoxMove>();
		

		if (Input.GetKeyDown(KeyCode.A)) //left
		{
			if (LeftWallScript.leftHitWall())
			{
				Debug.Log("Ran into Wall");
				endPosition = new Vector3(endPosition.x, endPosition.y, endPosition.z);
				moveToPoint = true;
			}
			else
			{
				Debug.Log("Out OF Wall");
				endPosition = new Vector3(endPosition.x - distanceToMove, endPosition.y, endPosition.z);
				moveToPoint = true;
			}
		}

		if (Input.GetKeyDown(KeyCode.D)) //Right
		{
			if (RightWallScript.rightHitWall())
			{
				endPosition = new Vector3(endPosition.x, endPosition.y, endPosition.z);
                moveToPoint = true;
			}
			else
			{
				endPosition = new Vector3(endPosition.x + distanceToMove, endPosition.y, endPosition.z);
				moveToPoint = true;
			}
		}

		if (Input.GetKeyDown(KeyCode.W)) //Up
		{
			if (UpWallScript.upHitWall())
			{
				//Debug.Log("Hit an Up Wall");
				endPosition = new Vector3(endPosition.x, endPosition.y, endPosition.z);
				moveToPoint = true;
			}
			else
			{
				//Debug.Log("Out Of Up Wall");
				endPosition = new Vector3(endPosition.x, endPosition.y + distanceToMove, endPosition.z);
				moveToPoint = true;
			}
		}

		if (Input.GetKeyDown(KeyCode.S)) //Down
		{
			if (DownWallScript.downHitWall())
			{
				endPosition = new Vector3(endPosition.x, endPosition.y, endPosition.z);
				moveToPoint = true;
			}
			
			else
			{
				endPosition = new Vector3(endPosition.x, endPosition.y - distanceToMove, endPosition.z);
				moveToPoint = true;
			}
		}
	}
}
