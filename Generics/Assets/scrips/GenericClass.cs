using UnityEngine;
using System.Collections;

// we voegen een Generic Type Paramter toe. Daardoor kunnen we deze data Class
// voor verschillende types gebruiken
// je kunt de Class nog een stuk netter maken door met
// getters en setters te werken
public class GenericClass<T> {

	public string name = "";
	private T value;

	public T GetValue() {
		return value;
	}

}
