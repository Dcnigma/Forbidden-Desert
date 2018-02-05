using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for auto title load.

public class Addtitles : MonoBehaviour {

	//Load game objects
	[SerializeField]
	private Transform puzzleField;

	[SerializeField]
	private GameObject btn;

	[SerializeField]
	private GameObject water;

	[SerializeField]
	private GameObject start;

	[SerializeField]
	private GameObject storm;

	[SerializeField]
	private GameObject btn2;
	//25 Titles must be load 1 start 1 storm 3 water 20 titles
	void Awake(){

		for (int i=0; i< 10; i++)  // I want to have fewer or more buttons, I have changed here, but nothing changed.
		{
			GameObject button = Instantiate (btn);
			button.name = "" + i;
			button.transform.SetParent (puzzleField, false);
		}




		for (int i=0; i< 1; i++)  // I want to have fewer or more buttons, I have changed here, but nothing changed.
		{
			GameObject button = Instantiate (storm);
			button.name = "" + i;
			button.transform.SetParent (puzzleField, false);
		}
//		
		for (int i=0; i< 3; i++)  // I want to have fewer or more buttons, I have changed here, but nothing changed.
		{
			GameObject button = Instantiate (water);
			button.name = "" + i;
			button.transform.SetParent (puzzleField, false);
		}
//		
		for (int i=0; i< 1; i++)  // I want to have fewer or more buttons, I have changed here, but nothing changed.
		{
			GameObject button = Instantiate (start);
			button.name = "" + i;
			button.transform.SetParent (puzzleField, false);

		}
		for (int i=0; i< 10; i++)  // I want to have fewer or more buttons, I have changed here, but nothing changed.
		{
			GameObject button = Instantiate (btn2);
			button.name = "" + i;
			button.transform.SetParent (puzzleField, false);
		}

	}

}