using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private GameObject MyCubee;
	private Vector3 vx;
    private Vector3 vz;
	private float d = 5.0f;
	// Use this for initialization
	void Start () {
        MyCubee = GameObject.Find("Cubee");
		vx = (float)0.1 * Vector3.right;
        vz = (float)0.1 * Vector3.up;
    }
	
	// Update is called once per frame
	void Update () {      
       // MyCube.transform.position += (float)0.03 * Vector3.left;
		MyCubee.transform.position += vx;
        MyCubee.transform.position += vz;
		float dd = d + 2;
		MyCubee.transform.Rotate(0, 0, dd);
	}
}