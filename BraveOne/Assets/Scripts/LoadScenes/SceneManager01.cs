using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager01 : MonoBehaviour {

	public static SceneManager01 Instance { set; get;}

	private void Awake()
	{
		Instance = this;
		Load ("Player");
		Load ("City01");
		//Load ("City02");
	}

	public void Load (string sceneName)
	{
		if (!SceneManager.GetSceneByName (sceneName).isLoaded)
			SceneManager.LoadScene (sceneName, LoadSceneMode.Additive);
	}

	public void Unload (string sceneName)
	{
		if (SceneManager.GetSceneByName (sceneName).isLoaded)
			SceneManager.UnloadScene (sceneName);
	}
}
