using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pictureload1 : MonoBehaviour
{

    // Source texture and the rectangular area we want to extract.
    public Texture2D sourceTex;
    public Rect sourceRect;

    void Start()
    {
        int x = Mathf.FloorToInt(sourceRect.x);
        int y = Mathf.FloorToInt(sourceRect.y);
        int width = Mathf.FloorToInt(sourceRect.width/2);
        int height = Mathf.FloorToInt(sourceRect.height/2);

        var  pix2 = sourceTex.GetPixel(x, y);
        Color[] pix = sourceTex.GetPixels(x, y, width, height);

        Texture2D destTex = new Texture2D(width, height);
        destTex.SetPixels(pix);
        destTex.Apply();

        // Set the current object's texture to show the
        // extracted rectangle.
        GetComponent<Renderer>().material.mainTexture = destTex;
    }




// Update is called once per frame
void Update()
    {
        
    }
}


