using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Color = UnityEngine.Color;



public class InitField2 : MonoBehaviour
{

    private GameObject BoxClone;
    public GameObject BulletPF;
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

        


        for (int i = 0; i < 40; i++)
            for (int j = 0; j < 40; j++)
                
                {

                Color pix2 = sourceTex.GetPixel(i, j  );

                Vector3 NewPos = new Vector3(1.0f*i, -25, 1.0f * j);
                    

                    BoxClone = Instantiate(BulletPF, NewPos, transform.rotation);
                    var color1 = (int)Random.Range(0, 255);
                    var color2 = (int)Random.Range(0, 255);
                    var color3 = (int)Random.Range(0, 255);
                //                   var df = new UnityEngine.Color(color1 / 255.0f, color2 / 255.0f, color3 / 255.0f);
                var ColorN = new UnityEngine.Color(color1 / 255.0f, color2 / 255.0f, color3 / 255.0f);
               
                
                    var Rend2 = BoxClone.GetComponent<Renderer>();
                    Rend2.material.SetColor("_Color", pix2);

                    Destroy(BoxClone, 125.5f);
                }




        






    }

}
