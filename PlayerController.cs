using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{


	private Rigidbody2D myRigidBody;
	public float jumpForce;
	public float moveSpeed;

	public bool hasJumped = false;
	public bool onGround = true;


	public Vector2 jumpDirection;

	Animator anim;




	void Start ()
	{

		myRigidBody = gameObject.GetComponent < Rigidbody2D > ();
		anim = GetComponentInChildren<Animator>();



	}

	
	// Update is called once per frame
	void Update ()
	{






		// jump
		if (!hasJumped && Input.GetKeyDown (KeyCode.Space)) { 

			//make the boxyMan jump in the direction the ballIndicator is pointing
			myRigidBody.AddForce (jumpDirection * jumpForce, ForceMode2D.Impulse);
			anim.SetFloat ("verticalSpeed", jumpForce);

			hasJumped = true;
		}
	
		// right
		if (onGround && Input.GetKey (KeyCode.RightArrow)) {
			Vector2 rightVector = new Vector2 ();
			rightVector.x = moveSpeed;
			anim.SetFloat("Speed", moveSpeed);

			myRigidBody.AddForce (rightVector);
		}

		// left
		if (onGround && Input.GetKey (KeyCode.LeftArrow)) { 
			Vector2 leftVector = new Vector2 ();
			leftVector.x = -moveSpeed;
			anim.SetFloat("Speed", -moveSpeed);

			myRigidBody.AddForce (leftVector);
		}



	}

}
