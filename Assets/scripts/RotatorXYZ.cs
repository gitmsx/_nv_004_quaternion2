using UnityEngine;
using System.Collections;


public class RotatorXYZ : MonoBehaviour {
	Quaternion originRotation;


	float angle;
	void Start () {
		angle = 0;
        originRotation=transform.rotation;


    }

	void FixedUpdate () {

        angle++;
        Quaternion rotationY = Quaternion.AngleAxis(angle, Vector3.up);
        Quaternion rotationX = Quaternion.AngleAxis(angle, Vector3.right);

        Quaternion rotationZ = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = originRotation * rotationY * rotationX* rotationZ;

	
	}
}
