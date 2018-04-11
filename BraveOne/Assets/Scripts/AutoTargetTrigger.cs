using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoTargetTrigger : MonoBehaviour {

	public Image lockOnTarget;


	void Start()
	{
		lockOnTarget.enabled = false;
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			lockOnTarget.enabled = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			lockOnTarget.enabled = false;

			Destroy (this.gameObject, 10);
		}
	}
}
