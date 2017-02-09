using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour
{

	public Slider volumeSlider;
	public LevelManager levelManager;
	private MusicManager musicManager;
	// Use this for initialization
	void Start ()
	{
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		Debug.Log (musicManager);
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}


	public void SaveandExit ()
	{
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		levelManager.LoadLevel ("01a Start");
	}
}
