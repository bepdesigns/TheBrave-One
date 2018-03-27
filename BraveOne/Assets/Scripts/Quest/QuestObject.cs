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
	public Image crystal;
	public Image killQuests;

	public bool isEnemyQuest;
	public string targetEnemy;
	public int enemiesToKill;
	private int enemyKillCount;

	public GameObject Reward;
	public Transform Player;

	public bool textOnQuest;
	private float waitTime = 2f;

	// Use this for initialization
	void Start () {
		textOnQuest = false;
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
				textOnQuest = true;

				if (textOnQuest) 
				{
					crystal.enabled = true;
					itemCountText.text = " " + itemsCount;
					StartCoroutine(TextWait());
				} 

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

				if (textOnQuest) 
				{
					killQuests.enabled = true;
					itemCountText.text = " " + enemyKillCount++;
					StartCoroutine(TextWait());
				}

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

	IEnumerator TextWait()
	{
		yield return new WaitForSeconds(waitTime);
		itemCountText.enabled = false;
		crystal.enabled = false;
		killQuests.enabled = false;

	}
}
