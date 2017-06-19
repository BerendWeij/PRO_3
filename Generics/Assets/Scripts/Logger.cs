using UnityEngine;
using System.Collections;

public class Logger : MonoBehaviour {

	void Start(){

		// eerste 'call' van Berend
		Debug.Log( GetParameterType<string>("test van Berend") );

		// 1) probeer verschillende waardes en Typen uit met GetParameterType. Dit mogen ook eigen Class & struct types zijn

		// 2) heb je redelijk wat geprobeerd? Ga dan kijken of je mijn RandomValue method aan kunt roepen. Sla de return value op in een variabele en Debug.Log() deze variabele
		int speed = RandomValue<int> (1, 5);
		string student = RandomValue<string> ("Yosha", "Jochem");
	}

	string GetParameterType<T> (T value) {
		Debug.Log ("The parameter contains: " + value);

		// we vragen het Type op van onze parameter en vervolgens daar de String naam van
		return value.GetType().Name;
	}

	T RandomValue<T> (T value1, T value2) {
		if (Random.Range(0, 2) == 0)
			return value1;
		else
			return value2;
	}

}
