using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour {
	public AudioClip soundEffect;
	// Use this for initialization
	void Start () {
		
	}

	IEnumerator Wait(){
		 yield return new WaitForSeconds(10.0f);
	}

    void Update()
    {
		if (Input.anyKeyDown) {
			//TODO Get sound to play before scene changes
			//GetComponent<AudioSource>().Play();
			//AudioSource.PlayClipAtPoint(soundEffect,gameObject.transform.position);
	        
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

		}
    }
}
