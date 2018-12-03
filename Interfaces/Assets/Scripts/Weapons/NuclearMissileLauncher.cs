using UnityEngine;

public class NuclearMissileLauncher : MonoBehaviour, IWeapon {

	public void Shoot() {
		Debug.Log("Alert, alert, we are launching a nuclear missile in 5, 4, 3, 2, 1....");
	}
}
