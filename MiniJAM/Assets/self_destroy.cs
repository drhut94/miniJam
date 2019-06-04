using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class self_destroy : MonoBehaviour {

    public GameObject image;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E)) {
            image.SetActive(false);
        }
	}
}
