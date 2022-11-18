using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Color = UnityEngine.Color;



public class InitField3 : MonoBehaviour
{

    private GameObject BoxClone;
    public GameObject BulletPF;
    public GameObject BulletPF2;
    // Start is called before the first frame update
    public Texture2D sourceTex;
    public Rect sourceRect;

    void Start()
    {

        Fire();
    }




    // Update is called once per frame
    void Update()
    {

    }


    void Fire()
    {

        int x = Mathf.FloorToInt(sourceRect.x);
        int y = Mathf.FloorToInt(sourceRect.y);
        int width = Mathf.FloorToInt(sourceRect.width);
        int height = Mathf.FloorToInt(sourceRect.height);




        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)

            {
                Vector3 NewPos = new Vector3(1.0f * i, -15, 1.0f * j);
                if ((i + j) % 2 == 1)
                {

                    BoxClone = Instantiate(BulletPF, NewPos, transform.rotation);

                }

                else

                {
                    BoxClone = Instantiate(BulletPF2, NewPos, transform.rotation);
                }


            }











    }

}
