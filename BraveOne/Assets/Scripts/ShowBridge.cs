using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBridge : MonoBehaviour 

{
	[Header("Active the Lever to open  the bridges")]
	//public Animation anim;
	public Animation lever;
	public GameObject bridge;
	public int enemiesToKill;
	public Text KeepOnKilling;
	//public Text EnemiesToKill;
	public Image lockImage;
	public Image unLockImage;

	private float waitTime = 2f;
		 

	// Use this for initialization
	void Start () {

		bridge.gameObject.SetActive(false);
		//anim = FindObjectOfType<Animation>();
		lever = GetComponentInChildren<Animation>();
		KeepOnKilling.enabled = false;
		//EnemiesToKill.enabled = false;
		lockImage.enabled = false;
		unLockImage.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			BridgeLock ();
			BridgeUnlock ();

		}
		
	}
	IEnumerator TextWait()
	{
		yield return new WaitForSeconds(waitTime);
		KeepOnKilling.enabled = false;
		lockImage.enabled = false;
		unLockImage.enabled = false;
		Destroy(gameObject);
	 
	}

	public void BridgeLock()
	{
		if (InventoKill.Refrence.KilledEnemies <= enemiesToKill && Input.GetKeyDown (KeyCode.E)) 
		{

			KeepOnKilling.text = "Bridge is Close.";
			KeepOnKilling.enabled = true;
			lockImage.enabled = true;
			unLockImage.enabled = false;
			StartCoroutine(TextWait());
		}
	}

	public void BridgeUnlock()
	{
		if (InventoKill.Refrence.KilledEnemies >= enemiesToKill && Input.GetKeyDown (KeyCode.E)) {
			//&& InventoKill.Refrence.haveKey
			//active the bridge
			bridge.gameObject.SetActive (true);
			lever.Play (lever.clip.name);
			//anim.Play (anim.clip.name);
			//anim.Stop ();

			KeepOnKilling.text = "Bridge is Open.";
			KeepOnKilling.enabled = true;
			lockImage.enabled = false;
			unLockImage.enabled = true;

			StartCoroutine(TextWait());
			InventoKill.Refrence.KilledEnemies = 0;
			//Destroy (this.gameObject, 1);
		}  
	}
}
