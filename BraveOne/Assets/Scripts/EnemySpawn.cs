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

	public bool isDead;
	public float Timer;
	public float Cooldown;
	public string EnemyName;
	private GameObject LastEnemy;


	public vCharacter chara;

	// Use this for initialization
	void Start () {
		chara = FindObjectOfType<vCharacter> ();
		isDead = false;
		this.gameObject.name = EnemyName + "spawn point";

	}

	void Update()
	{
		
	

	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			InvokeRepeating ("EnemySpawner", waitTime, repeatRate);

			//Destroy (gameObject, timeToDestroy);
			gameObject.GetComponent<BoxCollider> ().enabled = false;

			if(isDead == true)
				{
					EnemySpawner ();
				}
		}
		
	}
	void EnemySpawner()
	{
		// If the player has no health left...
		if (chara.currentHealth <= 0f)
		{
			// ... exit the function.

			Respawner ();
			return;
		}

		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, enemyPos.Length);
		Instantiate (enemy, enemyPos[spawnPointIndex].position, enemyPos[spawnPointIndex].rotation);
	}

	void Respawner()
	{
		if (isDead == true) {
			//If my enemy is death, a timer will start.
			Timer -= Time.deltaTime;

		}

		//If the timer is bigger than cooldown.
		if (Timer <= Cooldown) {

			//It will create a new Enemy of the same class, at this position.
			enemy.transform.position = transform.position;

			Instantiate (enemy);
			LastEnemy = GameObject.Find (enemy.tag + "(Clone)");
			LastEnemy.name = EnemyName;
			//My enemy won't be dead anymore.
			isDead = false;
			//Timer will restart.
			Timer = 0;
		}
	}
}
