using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
	public GameObject player;

    private Vector3 offset;

    void Start ()
	{
		if (GameObject.FindGameObjectWithTag ("Player")) {
			player = GameObject.FindGameObjectWithTag ("Player");
		}
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
