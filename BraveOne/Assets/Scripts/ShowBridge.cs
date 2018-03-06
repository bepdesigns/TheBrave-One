using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBridge : MonoBehaviour 

{
	[Header("Active the Lever to open  the bridges")]
	public Animation anim;
	public Animation lever;
	//public GameObject bridge;
	public int enemiesToKill;
	public Text KeepOnKilling;
	//public Text EnemiesToKill;

	private float waitTime = 2f;
		 

	// Use this for initialization
	void Start () {

		//bridge.gameObject.SetActive(false);
		anim = FindObjectOfType<Animation>();
		lever = FindObjectOfType<Animation>();
		KeepOnKilling.enabled = false;
		//EnemiesToKill.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			
			if (InventoKill.Refrence.KilledEnemies >= enemiesToKill && Input.GetKeyDown (KeyCode.E)) {
				//&& InventoKill.Refrence.haveKey
				//active the bridge
				//bridge.gameObject.SetActive (true);
				lever.Play (anim.clip.name);
				anim.Play (anim.clip.name);
				//anim.Stop ();
				KeepOnKilling.enabled = true;
				KeepOnKilling.text = "Bridge is Open.";
				StartCoroutine(TextWait());
				//Destroy (this.gameObject, 1);
			} else if (InventoKill.Refrence.KilledEnemies <= enemiesToKill && Input.GetKeyDown (KeyCode.E)) 
			{
				KeepOnKilling.enabled = true;
				KeepOnKilling.text = "Bridge is Close, Keep On Killing.";
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
