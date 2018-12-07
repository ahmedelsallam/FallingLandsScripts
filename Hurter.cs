using UnityEngine;
using System.Collections;

public class Hurter : MonoBehaviour
{
	public int damage = 100;


	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent <Player> ();
			{
				Player player = col.gameObject.GetComponent<Player> ();
				player.health -= damage;}
		}
	
	}
}
