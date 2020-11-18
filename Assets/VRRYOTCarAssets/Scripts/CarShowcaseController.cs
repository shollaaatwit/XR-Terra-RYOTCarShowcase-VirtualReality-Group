using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShowcaseController : MonoBehaviour
{
    public GameObject chosenCar;
    public GameObject rotateParent;
    public GameObject start;

    public static GameObject targetOne;
    public static GameObject targetTwo;
    public static GameObject targetThree;
    public static GameObject targetFour;

    public GameObject[] targets = new GameObject[] {targetOne, targetTwo, targetThree, targetFour};
    

    public static GameObject carOne;
    public static GameObject carTwo;
    public static GameObject carThree;
    public static GameObject carFour;

    public GameObject[] cars = new GameObject[] {carOne, carTwo, carThree, carFour};

    public float constantSpeed;
    public float fastSpeed;

    void Start()
    {



    }
    void Update()
    {
        CarRotater();
        CarRotation();
    }

    public void CarRotation()
    {
        rotateParent.transform.RotateAround(start.transform.position, Vector3.up, constantSpeed*Time.deltaTime);   

    }
    public void CarRotater()
    {
        int n = 0;
        while(n < 4)
        {
            cars[n].transform.Rotate(Vector3.down * Time.deltaTime * 40);
            n++;
        }

    }
    public void DisableRotate()
    {
        rotateParent.gameObject.SetActive(false);
    }
    public void ChosenCar()
    {

    }
}
