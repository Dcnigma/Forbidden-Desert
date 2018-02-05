using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundmusic : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	//Play Global
	private static backgroundmusic instance = null;
	public static backgroundmusic Instance
	{
		get { return instance; }
	}

	void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}

		DontDestroyOnLoad(this.gameObject);
	}
	//Play Gobal End

	// Update is called once per frame
	void Update () {

	}
}
