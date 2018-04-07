using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			Cursor.lockState = CursorLockMode.None;

			if (GameIsPaused) {
				Resume ();
			} 
			else 
			{
				Pause ();
			}
		}
	}

	public void Resume()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause()
	{
		Cursor.visible = true;
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void LoadMenu ()
	{
		Time.timeScale = 1f;
		//SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
		//SceneManager.LoadScene( 1, LoadSceneMode.Single);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void RestartGame ()
	{
		Time.timeScale = 1f;
		//SceneManager.LoadScene("The Adventure of Courage The Game", LoadSceneMode.Additive);
		//Scene scene = SceneManager.GetActiveScene(); 
		//SceneManager.LoadScene(scene.name);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		//string currentSceneName = SceneManager.GetActiveScene().name;
		//SceneManager.LoadScene(currentSceneName);
	}
}
