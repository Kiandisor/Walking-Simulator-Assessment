using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour 
{
    public static bool is_paused = false; /*!<Indirect reference to check if the game is paused, can be used in other classes to have different effects on them */

    public GameObject  pause_screen; /*!< GameObject that is acting as the pause screen to toggle off and on */

    // Update is called once per frame
    void Awake()
    {
		var buttons = Resources.FindObjectsOfTypeAll<Button>();
		MenusManger.late_add(buttons);
    }

	//Function to resume the game back to normal game time
	public void resumeGame()
	{
		pause_screen.SetActive(false);
		Time.timeScale=1f;
		is_paused=false;

		Cursor.lockState=CursorLockMode.Locked; // Lock the cursor to the centre of the screen
	}

	//Function to pause the game time and set the game to paused
	void pauseGame()
	{
		pause_screen.SetActive(true);
		Time.timeScale=0f;
		is_paused=true;

		Cursor.lockState=CursorLockMode.None; // Unlock the cursor from the centre of the screen
	}
	private void Update() 
    {
		//If the escape key is pressed enable the pause menu or disable it
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (is_paused) {
				resumeGame();
			}
			else {
				pauseGame();
			}
		}
	}
}
