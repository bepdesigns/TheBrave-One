using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.EventSystems;
using Invector.CharacterController;

public class EnemyQuest : MonoBehaviour 
{
	private vCharacter chara;
	private QuestManager theQM;
	private playerStats thePlayerStats;

	//public int damageToGive;
	public string enemyQuestName;
	public int expToGive;

	//public GameObject damageNumber;
	//public Transform hitPoint;


	// Use this for initialization
	void Start () 
	{
		chara = GetComponent<vCharacter> ();
		theQM = FindObjectOfType<QuestManager> ();
		thePlayerStats = FindObjectOfType<playerStats> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (chara.currentHealth <= 0) 
		{
			theQM.enemyKilled = enemyQuestName;
			chara.EnableRagdoll ();
			//thePlayerStats.AddExpreience (expToGive);
		}
	}

//	void OnTriggerEnter(Collider other)
//	{
	//	if (other.gameObject.tag == "Enemy") 
	//	{
		//	var clone = (gameObject) Instantiate(damageNumber, hitPoint.position, Quaternion.Euler (Vector3.zero));
	//clone.GetComponent<FloatingNumber>().damageNumber = damageToGive;
		//}
	//}
}
