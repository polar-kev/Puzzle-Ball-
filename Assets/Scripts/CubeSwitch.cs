using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSwitch : MonoBehaviour {
	public ActivateBySwitch token;
	public AudioClip soundEffect;
	private bool isActive = false;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision otherObject)
	{
		if (!isActive) {
			token.SwitchPressed();
			print("Switch pressed");
			isActive = true;
			AudioSource.PlayClipAtPoint(soundEffect,transform.position);
			//TODO Make the switch change colour when it's on
		}
	}
}
