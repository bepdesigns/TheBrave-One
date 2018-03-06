using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLerp : MonoBehaviour {


	public float smooth = 2f;
	private Vector3 newPosition;
	private float newIntensity;
	public Light lt;
	private Color newColour;





	// Use this for initialization
	void Awake () 
	{
		newPosition = transform.position;
		lt.intensity = newIntensity;
		newIntensity = lt.intensity;
		lt = GetComponent<Light>();
		newColour = lt.color;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		PositionChanging ();
		IntensityChanging ();
		ColourChanging ();
	}

	void  PositionChanging()
	{
		Vector3 positionA = new Vector3 (-5, 3, 0);
		Vector3 positionB =  new Vector3( 5, 3, 0);

		if(Input.GetKeyDown(KeyCode.Q))
			newPosition = positionA;
		if(Input.GetKeyDown(KeyCode.H))
			newPosition = positionB;

		transform.position = Vector3.Lerp(transform.position,newPosition, Time.deltaTime * smooth);
	}
	void  IntensityChanging()
	{
		float intensityA = 0.5f;
		float intensityB =  5f;

		if(Input.GetKeyDown(KeyCode.Q))
			newIntensity = intensityA;
		if(Input.GetKeyDown(KeyCode.H))
			newIntensity = intensityB;

		lt.intensity = Mathf.Lerp(lt.intensity,newIntensity, Time.deltaTime * smooth);
	}
	void  ColourChanging()
	{
		Color colourA = Color.red;
		Color colourB =  Color.green;


		if(Input.GetKeyDown(KeyCode.Q))
			newColour = colourA;
		if(Input.GetKeyDown(KeyCode.H))
			newColour = colourB;

		lt.color = Color.Lerp(lt.color, newColour, Time.deltaTime * smooth);
	}

}
