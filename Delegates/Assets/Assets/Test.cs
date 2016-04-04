using UnityEngine;
using System.Collections;
using System;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();

	}

}
