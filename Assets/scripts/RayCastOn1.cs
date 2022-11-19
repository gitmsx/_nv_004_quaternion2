using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void Ray_Delegate();


public class RayCastOn1 : MonoBehaviour
{

    public Transform PointerPosition;
    // public event Ray_Delegate ray_event;






    // Start is called before the first frame update
    void Start()
    {

        
        // ray_event += raycast;

        Ray_Delegate rD;
        rD = raycast;
    }



    public void raycast()
    {
    
        // Bit shift the index of the layer (8) to get a bit mask
     int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer


        Ray ray1 = new Ray(transform.position, Vector3.right*30);
        Ray ray2 = new Ray(transform.position, Vector3.forward*20);

        Debug.DrawRay(transform.position, Vector3.up * 20, Color.green);
        Debug.DrawRay(transform.position, Vector3.right * 20, Color.red);
        Debug.DrawRay(transform.position, Vector3.forward * 20, Color.blue);


     //  if (Input.GetMouseButtonDown(0)) {

            if (Physics.Raycast(ray1, out hit, 200, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            Debug.Log(hit.point);
            // PointerPosition.position=hit.point;
        }
        else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                Debug.Log("Did not Hit");
            }
       // }
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }


}
