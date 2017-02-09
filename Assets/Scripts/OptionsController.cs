using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour
{

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
	private MusicManager musicManager;
	// Use this for initialization
	void Start ()
	{
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		Debug.Log (musicManager);
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		musicManager.changeVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
		
	}


	public void SaveandExit ()
	{
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
		levelManager.LoadLevel ("01a Start");
		Debug.Log (difficultySlider.value);
	}
	
	public void SetDefaults ()
	{
		volumeSlider.value = .5f;
		difficultySlider.value = 1;

		
	}
}
