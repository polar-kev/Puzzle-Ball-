using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour {
	Scene scene;
	public Material switchGood;
	public AudioClip goodSound;
	public Obstacle obstacle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		gameObject.GetComponent<MeshRenderer> ().material = switchGood;
		AudioSource.PlayClipAtPoint (goodSound, transform.position);
		//obstacle.ResetPosition();
		scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.buildIndex);
	}
}
