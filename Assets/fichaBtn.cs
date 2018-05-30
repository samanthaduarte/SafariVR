using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fichaBtn : MonoBehaviour {
    public Button fichaButton;
    public GameObject plane;

    // Use this for initialization
    void Start()
    {
        Button eb = fichaButton.GetComponent<Button>();
        eb.onClick.AddListener(sOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void sOnClick()
    {
        plane.SetActive(true);
    }
}
