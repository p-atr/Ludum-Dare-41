using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

	public float speed;
    private float timeres = 0;
    public int endPos;
	Vector3 startPos;

	void Start () {
		this.startPos = this.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (startPos.x + ((Time.time - timeres) * speed) < endPos) {
            this.transform.position = new Vector3(startPos.x + ((Time.time - timeres) * speed), startPos.y, startPos.z);
        }
        else
        {
			this.transform.position = new Vector3(startPos.x, startPos.y, startPos.z);
            this.startPos = this.transform.position;
            timeres = Time.time;
        }
	}
}