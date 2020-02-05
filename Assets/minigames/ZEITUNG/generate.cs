using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;
using System.IO;

public class generate : MonoBehaviour {

	public Transform prefab;
	public Transform par; // parent
	public static Text wordToSearch;

	public static string rightWord;
	public static int rightWordCount;
	public static int wrongWordCount;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 9; i++) {
			Instantiate (prefab, new Vector3 (420f, 270f - i * 30f, -0.1f), Quaternion.identity, par);
		}
		for (int i = 	0; i < 12; i++) {
			Instantiate (prefab, new Vector3 (680f, 350f - i * 30f, -0.1f), Quaternion.identity, par);
		//prefab.transform.position.x + 0.1f, prefab.transform.position.y, 0
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void WordClicked() {
		
	}

	public static void changeWord(){
		//wordToSearch.text = 
	}

	//[MenuItem("Tools/ReadFile")]
	//public static void (string path){
			
	//}
}
