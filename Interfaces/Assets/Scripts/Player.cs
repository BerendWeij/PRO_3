using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private IWeapon currentWeapon;
	private HandGun handGun;
	private ShotGun shotGun;
	private NuclearMissileLauncher nuclearMissileLauncher;

	void Start () {
		// we halen even de andere components op
		handGun = GetComponent<HandGun>();
		shotGun = GetComponent<ShotGun>();
		nuclearMissileLauncher = GetComponent<NuclearMissileLauncher>();

		// we laten currentWeapon verwijzen naar de shotGun
		currentWeapon = shotGun;

		// volgende week gaan we deze code meer loosely coupled maken. Dan ga je echt de kracht van interfaces zien

		// waarom gebruiken we een interface?
		// omdat Classes alleen maar van elkaar mogen weten wat je bij elkaar mag doen. Niet 'hoe' het gebeurd.
		// Standaard regel: Program to an interface, not an implementation
		// met 'implementation' bedoeld men dat je hard tegen een bepaalde Class Type (bijvoorbeeld HandGun) aanscript
		// met interfaces wordt het heel duidelijk wat je mag verwachten van een Class. In de grote mensenwereld wordt
		// veel gewerkt met interfaces. .Net heeft hele conventies over welke interfaces je zou moeten hanteren
	}


	void OnMouseDown(){
		currentWeapon.Shoot();
	}
}
