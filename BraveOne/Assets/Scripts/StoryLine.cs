using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryLine : MonoBehaviour {

	public void LoadMenu ()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
	}

	public void LoadStory ()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("StoryTelling", LoadSceneMode.Additive);
	}
}
