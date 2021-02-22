using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabola3: MonoBehaviour {
    
    private GameObject MyCylinder;
    private float d = 0.2f;

    void Start() {
        MyCylinder = GameObject.Find("Cylinder");
    }

    void Update() {
        if (Input.GetKey(KeyCode.Q)) {
            d = -d;
        }
        MyCylinder.transform.Rotate(2 * d, 2 * d, 2 * d);
    }
}