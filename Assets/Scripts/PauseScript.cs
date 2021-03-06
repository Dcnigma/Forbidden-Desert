﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {


	public static bool GameIsPaused = false;

	public GameObject PauseMenuUI;
	// Update is called once per frame

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			if (GameIsPaused) {
				Resume ();
			} else {
				Pause ();
			}
		}
	}
	public void Resume()
	{
		PauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;		
	}

	void Pause ()
	{
		PauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void Pausebutton()
	{
		if (GameIsPaused) {
			Resume ();
		} else {
			Pause ();
		}
	}

		public void PauseMainMenu ()
	{
		SceneManager.LoadScene ("MainMenu");
	
	}
}
