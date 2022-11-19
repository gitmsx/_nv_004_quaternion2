using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Color = UnityEngine.Color;



public class InitField4 : MonoBehaviour
{

    private GameObject BoxClone;
    public GameObject BulletPF;
    public GameObject BulletPF2;
    public GameObject BulletPF3;
    public float         scale_pf;

    // Start is called before the first frame update
    public Texture2D sourceTex;
    public Rect sourceRect;

    void Start()
    {
        scale_pf=BulletPF.transform.localScale.x;
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




        for (int i = 0; i < 20; i++)
            for (int j = 0; j < 20; j++)

            {
                Vector3 NewPos = new Vector3(1.0f * i, 0, 1.0f * j);
                if ((i + j) % 2 == 1)
                {

                    BoxClone = Instantiate(BulletPF, NewPos, transform.rotation);

                }
                
                else if ((i + j) % 2 == 2)
                {

                    BoxClone = Instantiate(BulletPF2, NewPos, transform.rotation);

                }

                else

                {
                    BoxClone = Instantiate(BulletPF3, NewPos, transform.rotation);
                }


            }











    }

}