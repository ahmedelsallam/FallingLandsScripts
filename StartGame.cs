using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour {

	public string sceneName;

	public void LoadScene () {
		SceneManager.LoadScene(sceneName);
	}
}
