using UnityEngine;
using System.Collections;

public class floorDetector : MonoBehaviour
{


	public PlayerController controller;

	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.tag == "floor") {
			
			controller.hasJumped = false;
		}
	}

	void OnCollisionStay2D (Collision2D col)
	{
		if (col.gameObject.tag == "floor") {
			controller.onGround = true;
			controller.jumpDirection = col.contacts [0].normal;
		}
	}

	void OnCollisionExit2D (Collision2D col)
	{
		if (col.gameObject.tag == "floor") {
			controller.onGround = false;

		}
	}

}