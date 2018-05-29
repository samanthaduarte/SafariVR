using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuEmpezar : MonoBehaviour {

	public Button empezarButton;


	// Use this for initialization
	void Start () {
		Button  eb = empezarButton.GetComponent<Button>();
		eb.onClick.AddListener(sOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void sOnClick(){
		SceneManager.LoadScene(1);
	}


}
