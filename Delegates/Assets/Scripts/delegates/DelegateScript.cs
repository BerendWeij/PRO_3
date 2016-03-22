using UnityEngine;
using System.Collections;


public class DelegateScript : MonoBehaviour 
{

	// we declareren de 'handtekening' van deze delegate
	// dit noemen we de delegate template. Nu kunnen we variabelen aanmaken met het type GameObjectMover
	delegate void GameObjectMover(int speed); // delegates hebben een benaming als: ValueExtractor, MessageSender, etc. Soms krijgt hij de suffix Callback of Handler (ClickHandler, etc.)

	// vervolgens maken we een variabele aan die kan refereren naar de delegate
	// deze variabele heeft als 'type' GameObjectMover (de handtekening die we hierboven hebben gedeclareerd)
	// een delegate is een container van een functie (soort functie pointer)
	GameObjectMover MoveGameObject; // benaming als werkwoord (zoals bij functies): send, shoot, etc.
	
	// ! mag ook als local variable gemaakt worden
			
	void Start () 
	{

		// we laten de delegate variabele refereren naar de functie GoRight
		MoveGameObject = MoveLeft;

		// en we roepen de delegate aan
		MoveGameObject(100);

		// we laten de delegate variabele refereren naar de functie GoLeft
		MoveGameObject = MoveRight;

		// en we roepen de delegate aan
		MoveGameObject(89);
	}

	void MoveLeft(int speed){
		Debug.Log ("we gaan naar links met de snelheid: " + speed);
	}

	void MoveRight(int speed){
		Debug.Log ("we gaan naar rechts met de snelheid: " + speed);
	}



}
