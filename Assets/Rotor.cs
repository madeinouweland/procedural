using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour {
	public GameObject rotor1;
	public GameObject rotor2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rotor1.transform.Rotate(0, 10f, 0);
		rotor2.transform.Rotate(0, 10f, 0);
	}
}
