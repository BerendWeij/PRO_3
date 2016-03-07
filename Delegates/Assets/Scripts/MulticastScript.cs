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

	void FixedUpdate() {

		// ALTIJD checken of je delegate niet NULL is. Anders krijg je errors
		if(MoveGameObject != null){
			MoveGameObject();
		}

	}


	void OnMouseDown() {
		// als voorbeeld halen we 1 van de functies weg als je op dit gameobject klikt
		MoveGameObject -= MoveRight;
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
}
