using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelect : MonoBehaviour {
	
	public void twoplayers ()
	{
		//build Index way SceneManager.LoadScene(1)
		// Name way SceneManager.LoadScene("game")
		//Better way for using build index using Que's setup in buildsettings
		SceneManager.LoadScene(2);
	}
	public void treeplayers ()
	{
		//build Index way SceneManager.LoadScene(1)
		// Name way SceneManager.LoadScene("game")
		//Better way for using build index using Que's setup in buildsettings
		SceneManager.LoadScene(3);
	}
	public void forplayers ()
	{
		//build Index way SceneManager.LoadScene(1)
		// Name way SceneManager.LoadScene("game")
		//Better way for using build index using Que's setup in buildsettings
		SceneManager.LoadScene(4);
	}
	public void fiveplayers ()
	{
		//build Index way SceneManager.LoadScene(1)
		// Name way SceneManager.LoadScene("game")
		//Better way for using build index using Que's setup in buildsettings
		SceneManager.LoadScene(5);
	}


}