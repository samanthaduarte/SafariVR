using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerAnimal : MonoBehaviour {
	private Animator anim;

	public AudioClip sonidoAnimal;
	public float Volume=1.0f;
	AudioSource audio;
	public bool alreadyPlayed = false;
	//private Image ficha; 
	//public Canvas ficha; 

	//private GameObject jeep;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator>();
		anim.SetBool("makeSound",false);

		audio = GetComponent<AudioSource>();
		//GameObject go = GameObject.Find("Canvas");
		//ficha = go.GetComponent<Image>();
		//ficha = GetComponent<Canvas>();
		//ficha.gameObject.SetActive(false);
	}

	void OnTriggerEnter(Collider other){
		//if (other.gameObject.tag == "jeep"){
			anim.SetBool("makeSound",true);
			// Emitir sonido
			if (!alreadyPlayed){
				audio.PlayOneShot(sonidoAnimal,Volume);
				alreadyPlayed = true;
				//ficha.gameObject.SetActive(true); 
			}
			// Mostrar ficha
			// Audio de la ficha
		//}
		
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "jeep"){
			anim.SetBool("makeSound",false);
			//ficha.gameObject.SetActive(false); 
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
