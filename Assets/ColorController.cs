using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{

    public GameObject car;
    public GameObject[] materials;

    public void ChangeToBlack()
    {
        Debug.Log("We trying to chnage to black");
        ChangeColor(Color.black);
    }
    public void ChangeToGray()
    {
        ChangeColor(Color.gray);
    }
    public void ChangeToWhite()
    {
        ChangeColor(Color.white);
    }
    public void ChangeToRed()
    {
        ChangeColor(Color.red);
    }
    public void ChangeToBlue()
    {
        ChangeColor(Color.blue);
    }
    public void ChangeToGreen()
    {
        ChangeColor(Color.green);
    }
    public void ChangeToOrange()
    {
        ChangeColor(255, 159, 0);
    }
    public void ChangeToPurple()
    {
        ChangeColor(107, 0 , 170);
    }
    public void ChangeToLime()
    {
        ChangeColor(42, 212, 29);
    }

    private void ChangeColor(Color matColor)
    {

       for(int i = 0; i < materials.Length; i++)
        {
            materials[i].GetComponent<Renderer>().sharedMaterial.SetColor("_Color", matColor);
        } 

    }
    private void ChangeColor(float r, float g, float b)
    {

        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].GetComponent<Renderer>().sharedMaterial.color = new Color(r, g, b, 1);
        }

    }

}
