using UnityEngine;
using System.Collections;

public class NuclearMissileLauncher : MonoBehaviour, IWeapon {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Shoot() {
		Debug.Log("Alert, alert, we are launching a nuclear missile in 5, 4, 3, 2, 1....");
	}
}
