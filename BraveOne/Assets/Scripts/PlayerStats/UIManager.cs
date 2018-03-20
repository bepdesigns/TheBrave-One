using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	public static UIManager Instance;

	private playerStats thePS;
	public Text levelText;

	//public GameObject killCount;

	public Text EnemiesKilledText;
	private InventoKill ItK;

	// Use this for initialization
	void Start () 
	{
		//levelText.text = "Lvl: " + thePS.currentLevel;
		//EnemiesKilledText.text = "EnemiesKilled: " + ItK.KilledEnemies;

		//EnemiesKilledText = GameObject.Find("KillCount/EnemiesKilledText").GetComponent<Text>();
		//levelText = GameObject.Find("KillCount/LevelUpText").GetComponent<Text>();
		//killCount = GameObject.Find ("KillCount");
		//killCount = GameObject.Find("vUI/HUD/KillCount").GetComponent<GameObject>();
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
