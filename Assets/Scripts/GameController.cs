using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
	[SerializeField]
	private Sprite StandardTitle;
	[SerializeField]
	private Sprite WaterTitle;
	[SerializeField]
	private Sprite StartTitleimg;
	[SerializeField]
	private Sprite StormTitle;



	//public Sprite[] startload;
	//public Sprite[] stormload;
	public List<Sprite> gamePuzzles = new List<Sprite> ();
	public List<Sprite> waterPuzzles = new List<Sprite> ();
	public List<Button> titles = new List<Button>();
	public List<Button> Water = new List<Button>();
	public List<Button> StartTitle = new List<Button>();
	public List<Button> Storm = new List<Button>();
	public Sprite[] puzzles;
	public Sprite[] waterturn;
	private bool firstGuess, SecondGuess;

	private int countGuesses;
	private int countCorrectGuesses;
	private int gameGuesses;

	private int firstGuessIndex, secondGuessIndex;
	private string firstGuessPuzzle, secondGuessPuzzle;
	private int waterGuessIndex;
	private string waterGuessPuzzle;

	void Awake () {
		puzzles = Resources.LoadAll<Sprite> ("Sprites/Titles/");
		waterturn = Resources.LoadAll<Sprite> ("Sprites/Water/");
	}
	// Use this for initialization
	void Start () {
		GetButtons ();
		AddListeners ();
		AddGamepuzzles ();
		GetWater ();
		AddListenerswater ();
		AddWaterpuzzles ();
		GetStartpos ();
		AddListenersstart ();
		GetStorm ();
		AddListenersstorm ();
		Shuffle(gamePuzzles);
		Shuffle(waterPuzzles);
	}
	

	void GetButtons(){
		GameObject[] objects = GameObject.FindGameObjectsWithTag ("GameTitle");
			for (int i = 0; i < objects.Length; i++) {
			titles.Add(objects [i].GetComponent<Button>());
			titles [i].image.sprite = StandardTitle;
	}
	}
	void GetWater (){
	GameObject[] objects1 = GameObject.FindGameObjectsWithTag ("Water");
			for (int i = 0; i < objects1.Length; i++) {
			Water.Add(objects1 [i].GetComponent<Button>());
			Water [i].image.sprite = WaterTitle;
	}
	}
	void GetStartpos (){
	GameObject[] objects2 = GameObject.FindGameObjectsWithTag ("Start");	
	for (int i = 0; i < objects2.Length; i++) {
		StartTitle.Add(objects2 [i].GetComponent<Button>());
			StartTitle [i].image.sprite = StartTitleimg;
	}
	}
	void GetStorm (){
		GameObject[] objects = GameObject.FindGameObjectsWithTag ("Storm");	
		for (int i = 0; i < objects.Length; i++) {
			Storm.Add (objects [i].GetComponent<Button> ());
			Storm [i].image.sprite = StormTitle;
	}
	}



		void AddListeners(){
		foreach (Button btn in titles) 
			btn.onClick.AddListener (() => PickaTitle ());
	}		
	void AddListenerswater(){
		foreach (Button water in Water)
			water.onClick.AddListener (() => PickaWater ());
	}
		void AddListenersstart(){
		foreach (Button start in StartTitle)
			start.onClick.AddListener (() => startaTitle ());
	}
		void AddListenersstorm(){
					foreach(Button storm in Storm)
			storm.onClick.AddListener (() => Pickastorm ());
		}

	void AddGamepuzzles (){
		int looper = titles.Count;
		int indexs = 0;

		for (int i = 0; i < looper; i++) {
		
	//	if (indexs == looper / 2) {
	//		indexs = 0;
	//	}

		gamePuzzles.Add(puzzles[indexs]);
		
		indexs++;

		}}
		void	AddWaterpuzzles (){
		int waterlooper = Water.Count;
		int index = 0;

		for (int i = 0; i < waterlooper; i++) {
			

			waterPuzzles.Add(waterturn[index]);

		index++;

	}}

	void Shuffle(List<Sprite> list){

		for (int i = 0; i < list.Count; i++){

			Sprite temp = list[i];
			int randomIndex= Random.Range(0, list.Count);
			list [i] = list [randomIndex];
			list [randomIndex] = temp;
		
		}
			}

	public void PickaTitle(){
		string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;	
		Debug.Log ("Title clickt" + name);
		firstGuessIndex = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
		firstGuessPuzzle = gamePuzzles [firstGuessIndex].name;
		titles [firstGuessIndex].image.sprite = gamePuzzles [firstGuessIndex];
		//Guess game
//		if (!firstGuess) {
//			firstGuess = true;
//		
//			firstGuessIndex = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
//	    	firstGuessPuzzle = gamePuzzles [firstGuessIndex].name;
//			titles [firstGuessIndex].image.sprite = gamePuzzles [firstGuessIndex];
//				
//				} else  (!SecondGuess) {
//					SecondGuess = true;

//			secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
//			secondGuessPuzzle = gamePuzzles [secondGuessIndex].name;
//			titles [secondGuessIndex].image.sprite = gamePuzzles [secondGuessIndex];
				
		
//		titles [secondGuessIndex].image.sprite = gamePuzzles [secondGuessIndex];
	}
//}
//	}
	public void PickaWater(){
		string name  = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;	
		Debug.Log ("water clickt"+ name);
		waterGuessIndex = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
		waterGuessPuzzle = gamePuzzles [waterGuessIndex].name;
		Water [waterGuessIndex].image.sprite = waterPuzzles [waterGuessIndex];

	}

	public void startaTitle(){
		string name  = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;	
		Debug.Log ("start clickt"+ name);

	}
	public void Pickastorm(){
		string name  = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;	
		Debug.Log ("storm clickt"+ name);

	}
}
	


