using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSwitch : MonoBehaviour {
	public ActivateBySwitch token;
	public Material switchGood;
	public Material switchBad;
	public Material switchNormal;
	public AudioClip goodSound;
	public AudioClip badSound;

	private bool isActive = false;
	private int index;
	private static int count = 0;
	private static int activeCounter = 0;

	// Use this for initialization
	void Start () {
		index = count;
		count++;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision otherObject)
	{
		if ((activeCounter == index) && (!isActive)) {
			activateSwitch ();
		} else if(isActive){
			//do nothing is switch is already active
		}else{
			AudioSource.PlayClipAtPoint (badSound, transform.position);
		}

		if (activeCounter == count) {
			token.SwitchPressed();
		}
		print("Switch count: " + count);
		print("Active counter: " + activeCounter);
	}

	public void resetSwitch ()
	{
		isActive = false;
		gameObject.GetComponent<MeshRenderer>().material = switchNormal;

	}

	public void activateSwitch ()
	{
		isActive = true;
		gameObject.GetComponent<MeshRenderer> ().material = switchGood;
		activeCounter++;
		if (goodSound != null) {
			AudioSource.PlayClipAtPoint (goodSound, transform.position);
		}
	}

	public static void resetSwitchCount ()
	{
		count = 0;
		activeCounter = 0;
	}


}
