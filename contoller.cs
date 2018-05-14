using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contoller : MonoBehaviour {
	Rigidbody rb;
	Transform tr;
	float v;
	float h;
	float f;
	float mouseX;
	public Rigidbody mainObject;
	public Transform target;
	Rigidbody clone;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
		rb.AddForce (tr.forward * v * 50f);
		rb.AddForce (tr.forward * h * 50f);
		mouseX = Input.GetAxis ("Mouse X");
		Vector3 rotation = new Vector3 (0, mouseX * 5f, 0);
		tr.Rotate (rotation);
		f = Input.GetAxis ("Fire1");
		if (f > 0) {
			Instantiate (mainObject, tr.position, tr.rotation);
			clone.AddForce(tr.forward * 5000f);
		}
	}
}
