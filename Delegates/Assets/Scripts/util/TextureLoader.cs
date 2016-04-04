// Get the latest webcam shot from outside "Friday's" in Times Square
using UnityEngine;
using System;
using System.Collections;

public class TextureLoader {

	// COMMENT BEREND: je zou ook nog een errorCallback kunnen maken als parameter. Deze wordt uitgevoerd als er een error was


	/// <summary>
	/// Load the specified url and call succesCallback Method when ready
	/// </summary>
	/// <param name="url">URL to be loaded</param>
	/// <param name="succesCallback">Succes callback.</param>
	/// <param name="caller">GameObject that is calling this method. Needed for starting coroutine</param>
	public void Load(string url, Action<Texture> succesCallback, MonoBehaviour caller){
		caller.StartCoroutine( LoadTexture(url, succesCallback) );
	}

	/// <summary>
	/// Loads the texture.
	/// </summary>
	/// <returns>The texture.</returns>
	/// <param name="url">URL.</param>
	/// <param name="succesCallback">Succes callback.</param>
	IEnumerator LoadTexture(string url, Action<Texture> succesCallback){
		WWW www = new WWW(url);
		yield return www;

		// we zijn klaar met laden. Eerst kijken we of er geen error was
		if(!string.IsNullOrEmpty(www.error)){
			// er ging iets fout. We laten de errorcode zien
			Debug.LogError ("error:" + www.error);
		} else {
			// de texture is geladen. We roepen de callback aan en geven de texture door
			succesCallback(www.texture);
		}
	}
	
}