using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	public ActivateBySwitch token;
	Transform initialPosition;
	// Use this for initialization
	void Start () {
		initialPosition = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "LowerBound") {
			ActivateToken ();
		}

	}

	public void ResetPosition(){
		gameObject.transform.position = new Vector3(initialPosition.position.x, initialPosition.position.y,initialPosition.position.z);
	}

	void ActivateToken ()
	{
		token.SwitchPressed();
	}
}
