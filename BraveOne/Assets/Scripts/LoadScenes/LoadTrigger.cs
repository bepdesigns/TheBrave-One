using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTrigger : MonoBehaviour {

	public string loadName;
	public string unloadName;

	private void OnTriggerEnter(Collider col)
	{
		if (loadName != "")
			SceneManager01.Instance.Load (loadName);

		if (unloadName != "")
			StartCoroutine ("UnloadScene");
	}

	IEnumerator UnloadScene()
	{
		yield return new WaitForSeconds (.10f);
		SceneManager01.Instance.Unload (unloadName);
	}
}
