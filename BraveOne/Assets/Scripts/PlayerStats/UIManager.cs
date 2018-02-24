using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	private playerStats thePS;
	public Text levelText;

	// Use this for initialization
	void Start () 
	{
		thePS = GetComponent<playerStats> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		levelText.text = "Lvl: " + thePS.currentLevel;
	}
}
