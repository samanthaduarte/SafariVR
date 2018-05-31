using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColJeep : MonoBehaviour {

	public AudioClip sonido;

	// Use this for initialization
	void Start () {

		GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sonido;
	}

	void OnTriggerEnter(Collider other){
		GetComponent<AudioSource>().Play();
		// Si el jeep choca contra algun animal, parar por unos segundos
		if (other.tag == "zebra"){
			// Pausar por x tiempo
			// Encuentra la diferencia
			// Si no es correcto decir respuesta
		}
		if (other.tag == "lion"){
			// Pausar por x tiempo
			// Cuenta los leones
			// Si no es correcto decir respuesta

		}
		if (other.tag == "giraffe"){
			// Pausar por x tiempo
			// Cuantas manchas tiene la jirafa
			// Si no es correcto decir respuesta
		}
		if (other.tag == "elephant"){
			// Pausar por x tiempo
			// De que color es el elefante
			// Si no es correcto decir respuesta
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
