using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderSwitch : MonoBehaviour {
	public DeactivateBySwitch wall;
	public AudioClip soundEffect;
	public bool isActive = false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision otherObject)
	{
		if (!isActive) {
			wall.SwitchPressed();
			print("Switch pressed");
			isActive = true;
			//TODO Make the switch change colour when it's on
		}
		AudioSource.PlayClipAtPoint(soundEffect,transform.position);
	}
}