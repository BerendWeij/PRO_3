using UnityEngine;
using System.Collections;

public class GenericClass<T> {

	public string name = "";
	public T value;

	public T GetValue() {
		return value;
	}

}
