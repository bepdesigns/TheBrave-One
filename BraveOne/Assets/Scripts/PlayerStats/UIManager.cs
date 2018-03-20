using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	public static UIManager Instance;

	private playerStats thePS;
	public Text levelText;

	public Text EnemiesKilledText;
	private InventoKill ItK;

	void Awake()
	{
		
	}
	// Use this for initialization
	void Start () 
	{
		EnemiesKilledText = GameObject.Find("vUI/HUD/EnemiesKilledText").GetComponent<Text>();
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
