using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	public GameObject enemy;
	public Transform enemyPos;
	public float repeatRate = 3.0f;
	public float waitTime = 1.0f;
	public float timeToDestroy = 11.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			InvokeRepeating ("EnemySpawner", waitTime, repeatRate);
			Destroy (gameObject, timeToDestroy);
			gameObject.GetComponent<BoxCollider> ().enabled = false;
		}
		
	}
	void EnemySpawner()
	{
		Instantiate (enemy, enemyPos.position, enemyPos.rotation);
	}
}
