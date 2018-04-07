using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArmor : MonoBehaviour {

	public GameObject armor;

	void Start()
	{
		armor.gameObject.SetActive (false);
	}

	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			{
			armor.gameObject.SetActive (true);
			}
	}
}
