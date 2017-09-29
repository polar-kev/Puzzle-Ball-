using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour {
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
		transform.Rotate (new Vector3 (15,30,45) * Time.deltaTime);
	}

	void OnTriggerEnter (Collider collider)
	{
		if(collider.CompareTag("Player")){
			Destroy(gameObject);
			PickupItem.count--;
			levelmanager.PickupDestroyed();
			print("Items remaining:" + count);
			AudioSource.PlayClipAtPoint(ding,transform.position);
		}
	}

}
