using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public Text winText;
	public Text pressKeyText;
	private bool isGameWon = false;

	// Use this for initialization
	void Start () {
		winText.text = "";
		pressKeyText.text = "";
	}
	
	// Update is called once per frame
	void Update ()
	{	
		if (isGameWon && Input.anyKeyDown) {
			//SceneManager.LoadScene("Level_01");
			LoadNextLevel();
		}
	}

	public void PickupDestroyed ()
	{
		if (PickupItem.count <= 0 && MakerMobile.count <= 0) {
			winText.text = "YOU WIN"; 
			pressKeyText.text = "Press any key to continue";
			isGameWon = true;
		}
	}

	public void LoadNextLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		CylinderSwitch.resetSwitchCount();
		CubeSwitch.resetSwitchCount();
		print("Switch count reset");
	}



}
