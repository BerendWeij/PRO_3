using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericMethod : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// gewoon een simpele method call zoals jullie die gewend zijn
		// return type en parameter type staan vast op 'string'
		Debug.Log( "GetValue: " + GetValue("gd2") );

		// we roepen twee keer dezelfde Generic method aan met een andere type
		Debug.Log( "GetGenericValue int: " + GetGenericValue<int> (5) );
		Debug.Log( "GetGenericValue float: " + GetGenericValue<float> (6f) );

		// simpele arraylist. Deze gaan we vervolgens converteren
		ArrayList numbers = new ArrayList();
		numbers.Add(5);
		numbers.Add(3);
		numbers.Add(1);

		// we roepen de generic method Array2List aan. Deze method heeft een Generic return type
		List<int> converted = Array2List<int>(numbers);
		Debug.Log( "converted[0]: " + converted[0] );

		// we maken een instantie aan van de GenericClass met als type 'float'
		GenericClass<float> floatData = new GenericClass<float>();
		// je kun nu niks anders meer in value stoppen dan een float (probeer maar eens een string.. dan krijg je een foutmelding)
		floatData.value = 5f;
		Debug.Log( "floatData.GetValue(): " + floatData.GetValue() );

		// we maken een instantie aan van de GenericClass met als type 'ArrayList'
		// oftewel een data instantie die een lijst bij kan houden (inplaats van alleen een float)
		GenericClass<ArrayList> arrayListData = new GenericClass<ArrayList>();
		// je kunt bij deze instantie geen floats meer opslaan zoals bij het vorige voorbeeld. Alleen ArrayLists mogen
		// dit noemen we 'strong typed'
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
