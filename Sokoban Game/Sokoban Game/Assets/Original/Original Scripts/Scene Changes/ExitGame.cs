using UnityEngine;

namespace Original.Original_Scripts.Scene_Changes
{
	public class ExitGame : MonoBehaviour
	{

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetKey("escape"))
			{
				Debug.Log("escape and quit");
				Application.Quit();
			}
		}
 	
	}
}