using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour {
	public GameObject rotor1;
	public GameObject rotor2;
	// Use this for initialization
	void Start () {
		
	}

	private float _rot;
	private float _delta=.2f;
	
	// Update is called once per frame
	void Update () {
		_rot += _delta;
		if (_rot > 10)
        {
			_delta = _delta*-1;

        }
		if (_rot < -10)
        {
			_delta = _delta * -1;
        }

		this.transform.rotation = Quaternion.Euler(new Vector3(_rot / 10, 0, _rot));

		rotor1.transform.Rotate(0, 10f, 0);
		rotor2.transform.Rotate(0, 10f, 0);
	}
}
