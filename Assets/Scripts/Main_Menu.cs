using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour {


	public void PlayGame ()
	{
		//build Index way SceneManager.LoadScene(1)
		// Name way SceneManager.LoadScene("game")
		//Better way for using build index using Que's setup in buildsettings
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		SceneManager.LoadScene ("GameSelect");
	}

	public void QuitGame()
	{
		Debug.Log ("Quit!");
		Application.Quit ();

	}

	public void Pauzegame ()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}