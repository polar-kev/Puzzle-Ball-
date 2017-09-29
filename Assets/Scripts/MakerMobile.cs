using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakerMobile : MonoBehaviour {
	public static int count;
	public AudioClip ding;
	private LevelManager levelmanager;

	// Use this for initialization
	void Start () {
		count++;
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0,60,0) * Time.deltaTime);
	}

	void OnTriggerEnter (Collider collider)
	{
		if(collider.CompareTag("Player")){
			Destroy(gameObject);
			MakerMobile.count--;
			levelmanager.PickupDestroyed();
			AudioSource.PlayClipAtPoint(ding,transform.position);
		}
	}

}
