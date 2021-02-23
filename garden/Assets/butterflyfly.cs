using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterflyfly : MonoBehaviour {	

    private GameObject MyFly;
    private float vx;
    private float vz;
    private float a;
    private float t;
    // Use this for initialization
    void Start()
    {
        MyFly = GameObject.Find("SCharacter_Butterfly");    
        vx = 0.5f;
        vz = 0;
        a = (float)0.01;
        t = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        float x = MyFly.transform.position.x;
        float y = MyFly.transform.position.y;
        float z = MyFly.transform.position.z;
        MyFly.transform.position = new Vector3(x + a, y + a, z + vz);
        MyFly.transform.Rotate(vx + vz, vx + vz, 0);
        vz += a * t;
    }
}
