using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ai : MonoBehaviour {
	NavMeshAgent nav;
	Transform tr;
	public Transform target;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (target.position);

	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "Bullet") {
			Destroy (gameObject);
		}

	}

}
