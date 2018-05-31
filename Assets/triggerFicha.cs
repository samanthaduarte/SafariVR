using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerFicha : MonoBehaviour {
	public AudioClip sonidoFicha;
	public float Volume = 1.0f;
	AudioSource audio;
	public bool alreadyPlayed = false;

	//private GameObject jeep;

	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource>();

	}

	void OnTriggerEnter(Collider other){
			// Audio de la ficha
			if (!alreadyPlayed){
				audio.PlayOneShot(sonidoFicha,Volume);
				alreadyPlayed = true;
			}
			// Mostrar ficha
		
	}
	void OnTriggerExit(Collider other){

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
