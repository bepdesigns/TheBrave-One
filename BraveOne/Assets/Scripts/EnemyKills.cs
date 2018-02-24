using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.EventSystems;
using Invector.CharacterController;

public class EnemyKills : MonoBehaviour 
{
	public Transform Player;
	//public Transform Key;

	vCharacter chara;
	public float waitTime = 2.5f;


	// Use this for initialization
	void Start () {
		chara = GetComponent<vCharacter> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (chara.currentHealth <= 0) 
		{
			chara.EnableRagdoll ();

			StartCoroutine(DeathWait());
			//kill the enemy and drop the key

			//if (Input.GetKeyDown ("f")) 
			//{
				//InventoKill.Refrence.KilledEnemies += 1;
				//if (Key) {
					//drop the key
					//Key.gameObject.SetActive (true);
				//}
				//kill the enemy
				//InventoKill.Refrence.KilledEnemies = 1;
				//Destroy(gameObject);

			//}
		}
		
	}
	IEnumerator DeathWait()
	{
		yield return new WaitForSeconds(waitTime);
		InventoKill.Refrence.KilledEnemies += 1;
		Destroy(gameObject);
	}
}
