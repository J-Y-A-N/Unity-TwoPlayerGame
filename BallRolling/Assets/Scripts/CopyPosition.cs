using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CopyPosition : MonoBehaviour {

	[SerializeField]
	Transform transTarget;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transTarget.position;
	}
}
