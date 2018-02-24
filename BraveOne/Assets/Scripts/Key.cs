using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public Transform Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Vector3.Distance (transform.position, Player.position) < 6) {
			//kill the enemy and drop the key

			if (Input.GetKeyDown ("e")) 
			{
					//pick up key
				InventoKill.Refrence.haveKey = true;
				}
				//destroy the key
				Destroy(gameObject);
			}
		}
	}
