using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabola1 : MonoBehaviour {	

    private GameObject MySphere;
    private float vx;
    private float vz;
    private float a;
    private float t;
    // Use this for initialization
    void Start()
    {
        MySphere = GameObject.Find("Sphere");
        vx = 2.0f;
        vz = 0;
        a = -(float)0.01;
        t = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        float x = MySphere.transform.position.x;
        float y = MySphere.transform.position.y;
        float z = MySphere.transform.position.z;
        MySphere.transform.position = new Vector3(x + a, y + a, z + vz);
        MySphere.transform.Rotate(vx + vz, vx + vz, 0);
        vz += a * t;
    }
}
