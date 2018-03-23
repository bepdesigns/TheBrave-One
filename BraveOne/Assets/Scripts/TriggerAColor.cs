using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAColor : MonoBehaviour {


	public Renderer rend;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			rend.GetComponent<Renderer> ().material.color = Color.yellow;
		} else 
		{
			rend.GetComponent<Renderer> ().material.color = Color.green;
		}
			
	}
}
