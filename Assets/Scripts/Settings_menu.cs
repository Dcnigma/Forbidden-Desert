using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings_menu : MonoBehaviour {
	public AudioMixer Audiomixer;


	public void SetVolume (float volume) 
	{
		Debug.Log (volume);
		Audiomixer.SetFloat("volume", volume);
	} 

}
