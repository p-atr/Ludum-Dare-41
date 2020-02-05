using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class caught : MonoBehaviour {

	public bool hidden = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		print (hidden);
	}

	void OnTriggerExit2D(Collider2D other){
		print (hidden);
		if(other.tag == "enemy" && !hidden){
			SceneManager.LoadScene ("lost");
		}
	}
}
