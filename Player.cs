using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour
{
	public int health = 100;
	public string gameOverSceneName = "Game Over";



	void Update () {




		if (health <= 0) {
			SceneManager.LoadScene(gameOverSceneName);
		}
	}
}