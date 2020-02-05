using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	private Animator anim;
	public float speed;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector2 move = new Vector2 (moveHorizontal, 0);
		if (move.x < 0) {
			anim.SetBool ("direction", true);
			anim.SetBool ("isWalking", true);
		} else if (move.x > 0) {
			anim.SetBool ("direction", false);
			anim.SetBool ("isWalking", true);
		} else {
			anim.SetBool ("isWalking", false);
		}
		//rb.AddForce(move * speed);
		rb.MovePosition (new Vector2(this.transform.position.x, this.transform.position.y) + move * speed);
	}
}
