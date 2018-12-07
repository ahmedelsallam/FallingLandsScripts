using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GravityField : MonoBehaviour
{

	public float attractionForce = 3f;
	private Rigidbody2D boxyManRb;
	private float holeScale = 5f;
	public string loadScene;

	void Start ()
	{
		holeScale = transform.lossyScale.x * GetComponent<CircleCollider2D> ().radius;
	}

	void FixedUpdate ()
	{
		if (boxyManRb != null) {
//			print ("Pulling");
			Vector2 gravityDirection =
				transform.position - boxyManRb.transform.position;
			float distanceMult = Mathf.Max ((holeScale - gravityDirection.magnitude) / holeScale, 0);
			boxyManRb.AddForce (gravityDirection.normalized * attractionForce * distanceMult);

		
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {
//			print ("Pulled");
			boxyManRb = other.gameObject.GetComponentInParent<Rigidbody2D> ();
			SceneManager.LoadScene (loadScene);

		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.tag == "Player") {
//			print ("Pulled Off");
			boxyManRb = null;
		}
	}

}
