using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour {

	public GameObject followThis;
	public float leftEdge, rightEdge;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (followThis.transform.position.x > leftEdge && followThis.transform.position.x < rightEdge) {
			this.transform.position = new Vector3(followThis.transform.position.x, this.transform.position.y,this.transform.position.z);
		}
	}
}
