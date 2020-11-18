using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{

    public GameObject car;
    public GameObject[] materials;

    public Color black;
    public Color gray;
    public Color white;
    public Color red;
    public Color blue;
    public Color green;
    public Color orange;
    public Color purple;
    public Color lime;


    public void ChangeToBlack()
    {
        ChangeColor(black);
    }
    public void ChangeToGray()
    {
        ChangeColor(gray);
    }
    public void ChangeToWhite()
    {
        ChangeColor(white);
    }
    public void ChangeToRed()
    {
        ChangeColor(red);
    }
    public void ChangeToBlue()
    {
        ChangeColor(blue);
    }
    public void ChangeToGreen()
    {
        ChangeColor(green);
    }
    public void ChangeToOrange()
    {
        ChangeColor(orange);
    }
    public void ChangeToPurple()
    {
        ChangeColor(purple);
    }
    public void ChangeToLime()
    {
        ChangeColor(lime);
    }

    private void ChangeColor(Color matColor)
    {

       for(int i = 0; i < materials.Length; i++)
        {
            materials[i].GetComponent<Renderer>().sharedMaterial.SetColor("_Color", matColor);
        } 

    }

}
