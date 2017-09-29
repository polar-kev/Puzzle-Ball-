using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateBySwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SwitchPressed ()
	{
		gameObject.SetActive(false);
	}
}
