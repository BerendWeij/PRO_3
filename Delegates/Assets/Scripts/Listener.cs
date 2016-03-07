using UnityEngine;

public class Listener : MonoBehaviour
{
	void Awake () 
	{
		// Deze Class wil weten wanneer het geluid klaar is met spelen
		// daarvoor registreert hij zich voor de OnSoundCompleted Event / CallBack

		SoundPlayer soundPlayer = GameObject.Find("SoundPlayer").GetComponent<SoundPlayer>();

		soundPlayer.SoundCompleted += ContinueGame;

	}

	void ContinueGame()
	{
		print ("event is called, we should continue: " + this.name);
	}



}