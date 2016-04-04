using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericMethod : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log( "GetValue: " + GetValue("gd2") );

		Debug.Log( "GetGenericValue int: " + GetGenericValue<int> (5) );
		Debug.Log( "GetGenericValue float: " + GetGenericValue<float> (6f) );

		ArrayList numbers = new ArrayList();
		numbers.Add(5);
		numbers.Add(3);
		numbers.Add(1);

		List<int> converted = Array2List<int>(numbers);
		Debug.Log( "converted[0]: " + converted[0] );


		GenericClass<float> floatData = new GenericClass<float>();
		floatData.value = 5f;
		Debug.Log( "floatData.GetValue(): " + floatData.GetValue() );

		GenericClass<ArrayList> arrayListData = new GenericClass<ArrayList>();
		arrayListData.value = new ArrayList();
		arrayListData.value.Add(5);
		Debug.Log( "arrayListData.GetValue(): " + arrayListData.GetValue() );

	}
	
	string GetValue (string suffix) {
		Debug.Log( "GetValue type: " + suffix.GetType() );
		return suffix;
	}

	T GetGenericValue<T> (T suffix) {
		Debug.Log( "GetGenericValue type: " + suffix.GetType() );
		return suffix;
	}

	List<T> Array2List<T> (ArrayList source) {
		List<T> result = new List<T>();

		foreach (T value in source)
		{
			result.Add( value );
		}

		return result;

	}


}
