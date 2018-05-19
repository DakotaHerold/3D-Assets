using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    public float rotationAngle = 20f; 

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, rotationAngle * Time.deltaTime, 0)); 
	}
}
