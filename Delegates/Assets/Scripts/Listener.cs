using UnityEngine;

public class Listener : MonoBehaviour
{

	private SoundPlayer soundPlayer;

	void Awake () 
	{
		// Deze Class wil weten wanneer het geluid klaar is met spelen
		// daarvoor registreert hij zich voor de OnSoundCompleted Event / CallBack
		soundPlayer = GameObject.Find ("SoundPlayer").GetComponent<SoundPlayer>();
		soundPlayer.SoundCompleted += ContinueGame;

	}

	void ContinueGame()
	{
		print ("event is called, we should continue: " + this.name);
	}

	void OnMouseDown(){
		soundPlayer.PlaySound();
	}




}