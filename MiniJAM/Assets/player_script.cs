using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_script : MonoBehaviour {

    public GameObject image;
    public GameObject image2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) {
            reloadScene();
        }
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Lava")) {
            image2.SetActive(true);
            Invoke("reloadScene", 3);
        }

        if (other.gameObject.CompareTag("examen")) {
            image.gameObject.SetActive(true);
        }
    }

    public void reloadScene() {
        SceneManager.LoadScene("SampleScene");
    }
}
