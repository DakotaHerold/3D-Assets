using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    public enum Axis
    {
        X, 
        Y,
        Z
    }

    public Axis rotationAxis = Axis.Y; 
    public float rotationAngle = 20f; 

	// Update is called once per frame
	void Update () {

        switch(rotationAxis)
        {
            case Axis.X:
                transform.Rotate(new Vector3(rotationAngle * Time.deltaTime, 0, 0));
                break;
            case Axis.Y:
                transform.Rotate(new Vector3(0, rotationAngle * Time.deltaTime, 0));
                break;
            case Axis.Z:
                transform.Rotate(new Vector3(0, 0, rotationAngle * Time.deltaTime));
                break; 
        }

        
	}
}
