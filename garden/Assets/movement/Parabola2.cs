using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabola2 : MonoBehaviour {

    private GameObject MyCapsule;
   // private Vector3 vx;
   // private Vector3 vz;
    private float t;

    void Start()
    {
        MyCapsule = GameObject.Find("Capsule");
       // vx = (float)0.1 * Vector3.right;
       // vz = Vector3.zero;
        t = (float)1.5;
    }

    void Update()
    {
       // MyCapsule.transform.position += vx;
       // MyCapsule.transform.position += vz;
        MyCapsule.transform.Rotate(2*t, 2*t, 2*t);
    }
}
