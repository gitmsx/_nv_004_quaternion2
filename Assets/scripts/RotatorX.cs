using UnityEngine;
using System.Collections;


public class RotatorX  : MonoBehaviour {
	Quaternion originRotation;


    [SerializeField] AnimationCurve curve;
    [SerializeField] float speed = 3.7f;
    [SerializeField] float timemove = 7.0f;


    public Transform from;
    public Transform to;

    private float timeCount = 0.0f;


    float angle;
	void Start () {
		angle = 0;
        originRotation=transform.rotation;


    }

	void FixedUpdate () {

   //     angle = angle +0.2f;
     //   Quaternion rotationX = Quaternion.AngleAxis(angle, Vector3.up);
    //    transformrotation = originRotation * rotationX;

        transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, curve.Evaluate(timeCount / timemove));

        timeCount = timeCount + Time.deltaTime;


    }
}
