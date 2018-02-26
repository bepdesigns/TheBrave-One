using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoToKill : MonoBehaviour {

	public Text info;
	private float waitTime = 2f;
	// Use this for initialization
	void Start () {
		info.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			info.enabled = true;
			info.text = "Kill 5 Enemies to move on";
				StartCoroutine(TextWait());
			}

	}
	IEnumerator TextWait()
	{
		yield return new WaitForSeconds(waitTime);
		info.enabled = false;
		//Destroy(gameObject);
	}
}
