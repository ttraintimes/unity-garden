using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    // Public variable for turret turn speed
    public float turnSpeed = 20.0f; 
    private GameObject MyCube;
    private float d;

    // Start is called before the first frame update
    void Start()
    {
        MyCube = GameObject.Find("RotateCube");
        d = (float)0.5;
    }

    void Update()
    {
        MyCube.transform.Rotate(0, 2*d, 0);
        float rotation = 0.0f;
        // Check if Q or E key and calculate rotation
        if (Input.GetKey(KeyCode.Q))
        {
            rotation = -turnSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotation = turnSpeed * Time.deltaTime;
        }
        // Rotate turret dependent on calculated rotation
        Transform t = gameObject.transform;
        t.Rotate(0.0f, rotation, 0.0f);
    }
}
