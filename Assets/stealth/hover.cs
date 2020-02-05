using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour {

	public float speed;
	Vector3 startPos;
	public float amplitude;

	void Start () {
		this.startPos = this.transform.position;
	}

	// Update is called once per frame	
	void Update () {
		this.transform.position = new Vector3(startPos.x, startPos.y + Mathf.Sin(Time.time * speed) * amplitude, startPos.z);
	}
		
}
