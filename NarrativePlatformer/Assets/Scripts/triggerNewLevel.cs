using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class triggerNewLevel : MonoBehaviour {

	private string nextLevelName;
	private int nextLevel;
	public bool instant = false;
	// Use this for initialization
	//If we change level names this script needs to be updated. It tells us what level
	//we are currently in, so we can use this same script to end each level.
	void Start () {
	/*if (Application.loadedLevelName == "level_1") {
			nextLevelName = "Level2";
		} else if (Application.loadedLevelName == "Level2") {
			nextLevelName = "Level3";
		} else if (Application.loadedLevelName == "level3") {
			nextLevelName = "level_4";
		}*/
		nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
		if (nextLevel > SceneManager.sceneCountInBuildSettings - 1)
			nextLevel = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D Player){
		if (Player.gameObject.layer == LayerMask.NameToLayer ("character")) {
			StartCoroutine (NextLevel ());
		}
	}

	public IEnumerator NextLevel()
	{
		if (instant)
			SceneManager.LoadScene (nextLevel);
		else {
			float fadeTime = GameObject.Find ("Main Camera").GetComponent<SceneFading> ().BeginFade (1);
			yield return new WaitForSeconds (fadeTime);
			SceneManager.LoadScene (nextLevel);
		}
	}
}
