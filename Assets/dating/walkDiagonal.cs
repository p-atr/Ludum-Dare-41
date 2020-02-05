using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkDiagonal : MonoBehaviour {

	public Vector2 speed;
	private float timeres = 0;
	public Vector2 endPos;
	Vector3 startPos;

	void Start () {
		this.startPos = this.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (startPos.x + ((Time.time - timeres) * speed.x) < endPos.x && startPos.y + ((Time.time - timeres) * speed.y) > endPos.y) {
			this.transform.position = new Vector3(startPos.x + ((Time.time - timeres) * speed.x), startPos.y + ((Time.time - timeres) * speed.y), startPos.z);
		}
		else
		{
			this.transform.position = new Vector3(startPos.x, startPos.y, startPos.z);
			this.startPos = this.transform.position;
			timeres = Time.time;
		}
	}
}
