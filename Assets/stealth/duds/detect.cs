using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detect : MonoBehaviour {

	public GameObject player;
	private bool playerHidden = true;
	public float timeBeforeDetection;
	private float i = 0;

	public blink b;
	void Setup(){
		//GameObject g = GetComponent<GameObject> ();
		//	b = g.GetComponent<blink> ();
	}

	void Update () {
		if (playerHidden == false) {
			if (i >= timeBeforeDetection) {
				SceneManager.LoadScene ("lost");
				i = 0;
			}
			i += Time.deltaTime;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			this.playerHidden = false;
			b.blinking = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			this.playerHidden = true;

			b.blinking = false;
			i = 0;
		}
	}

}
