using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColLion : MonoBehaviour {
	private Animator anim;
	private AudioSource sonidoAnimal;
	public AudioClip sonidoAnimalC;
	public AudioSource sonidoInfo;
	private GameObject jeep;

	//public AudioSource as;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator>();
		anim.SetBool("makeSound",false);
		//GetComponent<AudioSource>().playOnAwake = false;
        //GetComponent<AudioSource>().clip = sonidoAnimal;
        sonidoAnimal = GetComponent<AudioSource>();
        jeep = GameObject.FindWithTag("jeep");
        			Debug.Log ("Entered");


        
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "jeep"){
			anim.SetBool("makeSound",true);
			// Emitir sonido
			//sonidoAnimal.Play(); 
			sonidoAnimal.PlayOneShot(sonidoAnimalC);
			Debug.Log ("Entered");
			// Mostrar ficha
			// Audio de la ficha
		}
		
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "jeep"){
			anim.SetBool("makeSound",false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
