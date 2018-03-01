using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBridge : MonoBehaviour 

{
	public Animation anim;
	//public GameObject bridge;
	public int enemiesToKill;
	public Text KeepOnKilling;
	//public Text EnemiesToKill;

	private float waitTime = 2f;

	// Use this for initialization
	void Start () {
		//bridge.gameObject.SetActive(false);
		anim = FindObjectOfType<Animation>();
		KeepOnKilling.enabled = false;
		//EnemiesToKill.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			KeepOnKilling.enabled = true;
			if (InventoKill.Refrence.KilledEnemies >= enemiesToKill) {
				//&& InventoKill.Refrence.haveKey
				//active the bridge
				//bridge.gameObject.SetActive (true);
				anim.Play (anim.clip.name);
				//anim.Stop ();

				Destroy (this.gameObject, 1);
			} else if (InventoKill.Refrence.KilledEnemies <= enemiesToKill) 
			{
				KeepOnKilling.text = "Keep On Killing.";
				StartCoroutine(TextWait());
			}
		}
		
	}
	IEnumerator TextWait()
	{
		yield return new WaitForSeconds(waitTime);
		KeepOnKilling.enabled = false;
		//Destroy(gameObject);
	}
}
