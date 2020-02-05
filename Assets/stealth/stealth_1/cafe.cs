using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cafe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerStay2D () {
		if (Input.GetKeyDown ("e")) {
			SceneManager.LoadScene ("dating");
		}
	}
}
