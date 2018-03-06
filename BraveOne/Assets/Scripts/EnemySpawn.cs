using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.EventSystems;
using Invector.CharacterController;

public class EnemySpawn : MonoBehaviour {

	public GameObject enemy;
	public Transform[] enemyPos;
	public float repeatRate = 10.0f;
	public float waitTime = 8.0f;
	//public float timeToDestroy = 11.0f;

	public vCharacter chara;

	// Use this for initialization
	void Start () {
		chara = FindObjectOfType<vCharacter> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			InvokeRepeating ("EnemySpawner", waitTime, repeatRate);
			//Destroy (gameObject, timeToDestroy);
			gameObject.GetComponent<BoxCollider> ().enabled = false;
		}
		
	}
	void EnemySpawner()
	{
		// If the player has no health left...
		if (chara.currentHealth <= 0f)
		{
			// ... exit the function.
			return;
		}

		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, enemyPos.Length);
		Instantiate (enemy, enemyPos[spawnPointIndex].position, enemyPos[spawnPointIndex].rotation);
	}
}
