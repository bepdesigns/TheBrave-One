using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestObject : MonoBehaviour {

	public int QuestNumber;

	public QuestManager theQM;

	public string startText;
	public string endText;

	public bool isItemQuest;
	public string targetItem;
	public int itemsToPickUp;

	private int itemsCount;

	public Text itemCountText;

	public bool isEnemyQuest;
	public string targetEnemy;
	public int enemiesToKill;
	private int enemyKillCount;

	public GameObject Reward;
	public Transform Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isItemQuest) 
		{
			if (theQM.itemColleted == targetItem) 
			{
				theQM.itemColleted = null;
				//EndQuest ();
				itemsCount++;
				itemCountText.text = "QuestItems " + itemsCount;
			}
			if (itemsCount >= itemsToPickUp) 
			{
				EndQuest ();
				itemCountText.enabled = false;
			}
		}
		if (isEnemyQuest) 
		{
			if (theQM.enemyKilled == targetEnemy) 
			{
				theQM.enemyKilled = null;

				enemyKillCount++;
				itemCountText.text = "EnemyQuest " + enemyKillCount++;
			}
			if (enemyKillCount >= enemiesToKill) 
			{
				EndQuest ();
				itemCountText.enabled = false;
			}
		}
	}

	public void StartQuest()
	{
		theQM.ShowQuestText (startText);
	}

	public void EndQuest()
	{
		theQM.ShowQuestText (endText);
		
		theQM.questCompleted[QuestNumber] = true;
		gameObject.SetActive (false);
		// Instantiate the projectile at the position and rotation of this transform
		Reward = Instantiate(Reward, Player.transform.position, Player.transform.rotation);

	}
}
