using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	private playerStats thePS;
	public Text levelText;

	public Text EnemiesKilledText;
	private InventoKill ItK;

	// Use this for initialization
	void Start () 
	{
		thePS = GetComponent<playerStats> ();
		ItK= GetComponent<InventoKill> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		levelText.text = "Lvl: " + thePS.currentLevel;
		EnemiesKilledText.text = "EnemiesKilled: " + ItK.KilledEnemies;
	}
}
