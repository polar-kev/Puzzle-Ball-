using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderSwitch : MonoBehaviour {
	public DeactivateBySwitch wall;
	public AudioClip goodSound;
	public AudioClip badSound;
	public ActivateBySwitch token;

	private bool isActive = false;
	public bool makeAppear = false;

	private int index;
	private static int count = 0;
	private static int activeCounter = 0;

	public Material switchGood;
	public Material switchBad;
	public Material switchNormal;

	// Use this for initialization
	void Start () {
		index = count;
		count++;
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void resetSwitch ()
	{
		isActive = false;
		gameObject.GetComponent<MeshRenderer>().material = switchNormal;

	}

	public void activateSwitch ()
	{
		isActive = true;
		AudioSource.PlayClipAtPoint (goodSound, transform.position);
		gameObject.GetComponent<MeshRenderer>().material = switchGood;
		activeCounter++;
	}

	void OnCollisionEnter (Collision otherObject)
	{
		if ((activeCounter == index) && (!isActive)) {
			activateSwitch ();
			print ("Switch pressed");
		} else if (isActive) {
			//do nothing is switch is already active
		} else {
			AudioSource.PlayClipAtPoint (badSound, transform.position);
		}

		if (activeCounter == count) {

			if (wall != null) {
				wall.SwitchPressed();
			}
		}
		print("Switch count: " + count);
		print("Active counter: " + activeCounter);

	}

	public static void resetSwitchCount ()
	{
		count = 0;
		activeCounter = 0;
	}
}