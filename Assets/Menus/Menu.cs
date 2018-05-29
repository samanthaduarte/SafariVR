using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public Button sabanaButton;
	public Button bosqueButton;
	public Button poloButton;

	// Use this for initialization
	void Start () {
		Button sb = sabanaButton.GetComponent<Button>();
		Button bb = bosqueButton.GetComponent<Button>();
		Button pb = poloButton.GetComponent<Button>();
		sb.onClick.AddListener(sOnClick);
		bb.onClick.AddListener(bOnClick);
		pb.onClick.AddListener(pOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void sOnClick(){
		SceneManager.LoadScene(2);
	}
	public void bOnClick(){
		Debug.Log("abriendo bosque");
	}
	public void pOnClick(){
		Debug.Log("abriendo polo");
	}

}
