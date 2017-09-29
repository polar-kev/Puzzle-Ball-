using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBySwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SwitchPressed ()
	{
		gameObject.SetActive(true);
	}
}
