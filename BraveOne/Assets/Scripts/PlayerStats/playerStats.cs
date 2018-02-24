using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.EventSystems;
using Invector.CharacterController;

public class playerStats : MonoBehaviour 
{
	public int currentLevel;

	public int currentExp;

	public int[] toLevelUp;

	public int[] HPLevels;
	public int[] attackLevels;
	public int[] defenceLevels;

	public int currentHP;
	public int currentAttack;
	public int currentDefence;

	private vCharacter pHealth;

	// Use this for initialization
	void Start () {
		currentHP = HPLevels[1];
		currentAttack = attackLevels[1];
		currentDefence = defenceLevels [1];
		pHealth = GetComponent<vCharacter> ();

		//pHealth = FindObjectOfType<vCharacter> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentExp >= toLevelUp [currentLevel]) 
		{
			//currentLevel++;
			LevelUp();
		}
	}
	public void AddExpreience(int experienceToAdd)
	{
		currentExp += experienceToAdd;
	}

	public void LevelUp()
	{
		currentLevel++;
		currentHP = HPLevels [currentLevel];

		pHealth.maxHealth = currentHP;
		pHealth.currentHealth += currentHP - HPLevels [currentLevel - 1];
		currentAttack = attackLevels[currentLevel];
		currentDefence = defenceLevels [currentLevel];

	}
}
