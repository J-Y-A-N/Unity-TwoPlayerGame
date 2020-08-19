using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour {

	[SerializeField]
	Vector3 v3Force;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().velocity += v3Force;
	}
}
