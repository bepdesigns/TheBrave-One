using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoKill : MonoBehaviour 
{

	public static InventoKill Refrence;
	public int KilledEnemies;
	public bool haveKey;

	// Use this for initialization
	void Awake () {
		Refrence = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
