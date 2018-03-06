using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Triggers : MonoBehaviour {

	bool enter_1;
	bool enter_2;
	bool enter_3;
	bool enter_4;

    bool button_pressed;
 
	public GameObject Lever_1;
	public GameObject Lever_2;
	public GameObject Lever_3;
	public GameObject Lever_4;
	public GameObject Bridge1;
	public GameObject Bridge11;
	public GameObject Bridge2;
	public GameObject Bridge21;
	public GameObject Bridge3;
	public GameObject Bridge31;
	public GameObject Bridge4;
	public GameObject Bridge41;

    public GameObject myBossButton;
    public GameObject bossWall;
    public GameObject turretBoss;

    public AudioClip boss_button_sound;
    public AudioClip myWall_sound;


	void Start () {
		enter_1 = false;
        enter_2 = false;
        enter_3 = false;
        enter_4 = false;

        button_pressed = false;

        turretBoss.SetActive(false);
	}

	void Update()
	{
		if (enter_1 == true && Input.GetKeyDown (KeyCode.F)) 
		{
			Bridge1.GetComponent<Animation> ().Play ("Bridge_Extend");
			Bridge11.GetComponent<Animation> ().Play ("Bridge_Extend_2");
			Lever_1.GetComponent<Animation> ().Play ("Lever_Activated");
		}
		if (enter_2 == true && Input.GetKeyDown (KeyCode.F)) 
		{
			Bridge2.GetComponent<Animation> ().Play ("Bridge_Extend");
			Bridge21.GetComponent<Animation>().Play ("Bridge_Extend_2");
			Lever_2.GetComponent<Animation> ().Play ("Lever_Activated");
		}
		if (enter_3 == true && Input.GetKeyDown (KeyCode.F)) 
		{
			Bridge3.GetComponent<Animation> ().Play ("Bridge_Extend");
			Bridge31.GetComponent<Animation>().Play ("Bridge_Extend_2");
			Lever_3.GetComponent<Animation> ().Play ("Lever_Activated");
		}
		if (enter_4 == true && Input.GetKeyDown (KeyCode.F)) 
		{
			Bridge4.GetComponent<Animation> ().Play ("Bridge_Extend");
			Bridge41.GetComponent<Animation>().Play ("Bridge_Extend_2");
			Lever_4.GetComponent<Animation> ().Play ("Lever_Activated");
		}
        if (button_pressed == true && Input.GetKeyDown (KeyCode.F)) 
        {
            Debug.Log("Button_Pressed");
            myBossButton.GetComponent<Animation>().Play("Button_Pressed");
            bossWall.GetComponent<Animation>().Play("Boss_Wall_Down");
            StartCoroutine(WaitForSound());
            turretBoss.SetActive(true);
        }
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "Lever_1") 
		{
			enter_1 = true;
		}
		if (other.gameObject.name == "Lever_2") 
		{
			enter_2 = true;
		}
		if (other.gameObject.name == "Lever_3") 
		{
			enter_3 = true;
		}
		if (other.gameObject.name == "Lever_4") 
		{
			enter_4 = true;
		}
            
        if (other.gameObject.tag == "Boss_Button")
        {
            button_pressed = true;
        }
	}

    IEnumerator WaitForSound()
    {
        print(Time.time);
        AudioSource.PlayClipAtPoint(boss_button_sound, new Vector3(0, 0, 1970));
        yield return new WaitForSeconds(1);
        AudioSource.PlayClipAtPoint(myWall_sound, new Vector3(0, 0, 1970));
        print(Time.time);
    }
}
