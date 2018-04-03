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
	private float waitTime = 3f;

	public GameObject crystals;
	public GameObject heLLboY;

	// Use this for initialization
	void Start () {
		textOnQuest = false;
		heLLboY.SetActive (false);
		crystals.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isItemQuest) 
		{
			crystals.SetActive (true);
			if (theQM.itemColleted == targetItem) 
			{
				theQM.itemColleted = null;
				//EndQuest ();
				itemsCount++;
				textOnQuest = true;

				if (textOnQuest) 
				{
					crystal.enabled = true;
					itemCountText.enabled = true;
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
			
			heLLboY.SetActive (true);
			if (theQM.enemyKilled == targetEnemy) 
			{
				theQM.enemyKilled = null;


				enemyKillCount++;
				textOnQuest = false;

				if (textOnQuest) 
				{
					killQuests.enabled = true;
					itemCountText.enabled = true;
					itemCountText.text = " " + enemyKillCount++;
					StartCoroutine(TextWaitTwo());

				}
			}
			if (enemyKillCount >= enemiesToKill) 
			{
				
				EndQuest ();

			}

		}
	}

	public void StartQuest()
	{
		theQM.ShowQuestText (startText);

	}

	public void EndQuest()
	{
		
		//StartCoroutine(TextWaitTwo());
		theQM.ShowQuestText (endText);
		//killQuests.enabled = false;

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

	}
	IEnumerator TextWaitTwo()
	{
		yield return new WaitForSeconds(waitTime);
		itemCountText.enabled = false;
		killQuests.enabled = false;

	}
}
