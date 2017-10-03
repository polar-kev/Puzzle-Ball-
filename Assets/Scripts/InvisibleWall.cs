using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour {
	public GameObject ignoreCollisionObject1;
	public GameObject ignoreCollisionObject2;

	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision(GetComponent<Collider>(),ignoreCollisionObject1.GetComponent<Collider>());
		Physics.IgnoreCollision(GetComponent<Collider>(),ignoreCollisionObject2.GetComponent<Collider>());
	}
}
