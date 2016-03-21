using UnityEngine;
using System.Collections;

public class SoundPlayer : MonoBehaviour
{
	
	// we declareren een handtekening zonder parameters (mag ook met)
	public delegate void SoundCompletedEventHandler(); // events geven we qua benaming altijd de suffix EventHandler

	// we declareren de daadwerkelijke variabele die kan verwijzen naar methods
	public SoundCompletedEventHandler SoundCompleted;

	// SoundLoadedCallback
	public delegate void SoundLoadedCallback(string data);


	void Start(){

	}
		
	/*
	 * Waarom zijn delegates & events handig?
	 * - ze kunnen je helpen met het switchen tussen states
	 * - super handig voor herbruikbaarheid
	 * - ze helpen je met encapsulation. Je brengt meer een API aan in je code en daardoor wordt je code meer 'loosely coupled'
	 * */

	public void PlaySound(){
		StartCoroutine(WaitForCompletion());
	}

	IEnumerator WaitForCompletion() {
		yield return new WaitForSeconds(3.0f);
		if(SoundCompleted != null)
			SoundCompleted();
	}

	public void LoadSound(string url, SoundLoadedCallback callback){
		// mooie logica om het geluidsbestand te laden
		// als hij klaar is voeren we de callback uit

		callback("dit is het muziek bestand");
	}



}
