using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour {

	public int timebetweenblinks;
	public bool blinking = false;
	public Renderer obj;

	private int i = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (blinking) {
			if (i >= timebetweenblinks) {
				obj.enabled = !obj.enabled;	
				i = 0;
			}
			i++;
		} else {
			obj.enabled = false;
		}
	}

}
