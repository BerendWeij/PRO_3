using UnityEngine;

public class HandGun : MonoBehaviour, IWeapon {
	
	public void Shoot() {
		Debug.Log("shooting HandGun");
	}
}
