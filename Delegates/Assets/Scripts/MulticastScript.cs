using UnityEngine;
using System.Collections;

public class MulticastScript : MonoBehaviour 
{

	// we declareren de 'handtekening' van de Multicast delegate (zonder parameter dit keer)
	delegate void GameObjectMover();

	// vervolgens maken we een variabele aan die kan refereren naar verschillende methods
	GameObjectMover MoveGameObject;	
	
	void Start () 
	{
		// we voegen beide functies toe aan de delegate
		MoveGameObject += MoveRight;
		MoveGameObject += MoveUp;
	}

	void Update() {

		// ALTIJD checken of je delegate niet NULL is (!= null). Anders krijg je errors
		if(MoveGameObject != null){
			MoveGameObject();
		}
	}

	// eerste functie die gebruikt kan worden voor een delegate
	void MoveRight()
	{
		Debug.Log("Move to the right");
	}

	// tweede functie die gebruikt kan worden voor een delegate
	void MoveUp()
	{
		Debug.Log("Move up");
	}

	void OnMouseDown(){
		MoveGameObject -= MoveUp;
	}

	// @ voorbeeld van het afmelden bij een delegate -=
}
