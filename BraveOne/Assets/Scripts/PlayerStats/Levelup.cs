using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelup : MonoBehaviour {


	//Variable
	public int level;
	private float experience;
	private float experienceRequired;

	public float hp;  //For testing purposes

	//Methods

	// Use this for initialization
	void Start () 
	{
		level = 1;
		hp = 100;
		experience = 0;
		experienceRequired = 100;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Exp ();

		if (Input.GetKeyDown (KeyCode.O)) 
		{
			experience += 100;
		}
	}

	void RankUp()
	{
		level += 1;
		experience = 0;

		switch (level) 
		{
		case 2:
			hp = 200;
			experienceRequired = 200;
			break;
		case 3:
			hp = 300;
			experienceRequired = 300;
			Debug.Log ("Congratulation! You have hit level 3 on your Character!");
			break;
		}
	}

	void Exp()
	{
		if (experience >= experienceRequired)
			RankUp ();
	}
}
