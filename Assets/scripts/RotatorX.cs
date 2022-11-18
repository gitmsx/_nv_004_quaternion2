using UnityEngine;
using System.Collections;


public class RotatorX  : MonoBehaviour {
	Quaternion originRotation;


	float angle;
	void Start () {
		angle = 0;
        originRotation=transform.rotation;


    }

	void FixedUpdate () {

        angle = angle +0.1f;
        Quaternion rotationX = Quaternion.AngleAxis(angle, Vector3.up);
        

        
        transform.rotation = originRotation * rotationX;

	
	}
}
