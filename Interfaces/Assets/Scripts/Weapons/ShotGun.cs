using UnityEngine;

public class ShotGun : MonoBehaviour, IWeapon {

	public void Shoot() {
		Debug.Log("shooting ShotGun");
	}
}