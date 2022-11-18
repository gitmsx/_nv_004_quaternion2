using UnityEngine;
using System.Collections;


public class RotatorY : MonoBehaviour {
	Quaternion originRotation;


	float angle;
	void Start () {
		angle = 0;
        originRotation=transform.rotation;


    }

	void FixedUpdate () {

        angle = angle +0.1f;
        Quaternion rotationY = Quaternion.AngleAxis(angle, Vector3.up);
        //Quaternion rotationX = Quaternion.AngleAxis(angle, Vector3.right);

        //Quaternion rotationZ = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = originRotation * rotationY  ;

	
	}
}
