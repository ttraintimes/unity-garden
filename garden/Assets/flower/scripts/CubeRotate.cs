using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    // Public variable for turret turn speed
    public float turnSpeed = 1.5f; 
    private GameObject MyCube;
   // private float d;

    // Start is called before the first frame update
    void Start()
    {
        MyCube = GameObject.Find("RotateCube");
       
    }

    void Update()
    {
       // MyCube.transform.Rotate(0, d + Time.deltaTime, 0);
        Transform t = MyCube.transform;
        t.Rotate(0.0f, turnSpeed, 0.0f);
      // turnSpeed++;
        
    }
}
