using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
	private AudioSource audioSource;
	public AudioClip[] levelMusicChangeArray;
	// Use this for initialization
	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load: " + name);
	}
	
	
	void Start ()
	{
		audioSource = GetComponent<AudioSource> ();
		
	}
	
	
	public void changeVolume (float volume)
	{
		audioSource.volume = volume;
	}
	
	
	
	// Update is called once per frame
	void OnLevelWasLoaded (int level)
	{
		AudioClip thisLevelMusic = levelMusicChangeArray [level];
		Debug.Log ("Playing clip: " + thisLevelMusic);
		if (thisLevelMusic) {
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
}
