using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxMenu : MonoBehaviour {

	public Material sky;

	// Use this for initialization
	void Start () {
		RenderSettings.skybox = sky;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
