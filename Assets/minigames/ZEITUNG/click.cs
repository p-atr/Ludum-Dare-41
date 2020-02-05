using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour {

	private Button btn;
	private Text txt;
	// Use this for initialization
	void Start () {
		//btn = GetComponent<Button> ();
		txt = GetComponent<Text> ();
//		btn.onClick.AddListener (clicked ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void clicked(){
		if (txt.text == generate.rightWord) {
			generate.rightWordCount++;
			generate.changeWord ();
		} else {
			generate.wrongWordCount++;
		}
		Destroy (this);	
	}
}
