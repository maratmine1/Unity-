using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
	Rigidbody rb;
	Transform tr;
	float v;
	float h;
	bool isGrounded=false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
		rb.AddForce (tr.forward * v * 100f);
		Vector3 rotation = new Vector3 (0, h * 5f, 0);
		tr.Rotate (rotation);
		if (Input.GetKeyDown (KeyCode.Space)&& isGrounded==true) {
			Vector3 jump = new Vector3 (0, 200, 0);
			rb.AddForce(jump);
			isGrounded = false;
		}

	}
	void OnCollisionStay(Collision arg){
		isGrounded = true;
	}
}
