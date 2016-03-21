using UnityEngine;
using System.Collections;

public class ShotGun : MonoBehaviour, IWeapon {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Shoot() {
		Debug.Log("shooting ShotGun");
	}
}
