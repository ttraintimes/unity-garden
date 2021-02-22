using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uniform : MonoBehaviour {

    private GameObject MyCube;
	private Vector3 vx;
    private Vector3 vz;
	private float d = 2.0f;
	// Use this for initialization
	void Start () {
        MyCube = GameObject.Find("Cube");
		vx = (float)0.1 * Vector3.right;
        vz = (float)0.1 * Vector3.up;
    }
	
	// Update is called once per frame
	void Update () {      
       // MyCube.transform.position += (float)0.03 * Vector3.left;
		MyCube.transform.position += vx;
        MyCube.transform.position += vz;
		float dd = d + 1;
		MyCube.transform.Rotate(dd, dd, 0);
	}
}
