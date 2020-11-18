using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public enum UIStates { Home, Environment, View, Lights, Materials, ChooseCar };
    UIStates currState;

    public GameObject Home, Environment, View, Lights, Materials, ChooseCar;

    public UIStates defaultState = UIStates.Home;

    Vector3 homePosition;

    void Start()
    {
        //add panels here so they are all on top of each other
        currState = defaultState;
        homePosition = Home.transform.position;
        Environment.transform.position = homePosition;
        View.transform.position = homePosition;
        Materials.transform.position = homePosition;
        Lights.transform.position = homePosition;
        ChooseCar.transform.position = homePosition;
    }


    void Update()
    {

        //manages what happens in each state

        //home
        if (currState == UIStates.Home)
        {
            Home.SetActive(true);
        }
        else
        {
            Home.SetActive(false);
        }

        //environement
        if (currState == UIStates.Environment)
        {
            Environment.SetActive(true);
        }
        else
        {
            Environment.SetActive(false);
        }

        //view
        if (currState == UIStates.View)
        {
            View.SetActive(true);
        }
        else
        {
            View.SetActive(false);
        }

        //lights
        if (currState == UIStates.Lights)
        {
            Lights.SetActive(true);
        }
        else
        {
            Lights.SetActive(false);
        }

        //materials
        if (currState == UIStates.Materials)
        {
            Materials.SetActive(true);
        }
        else
        {
            Materials.SetActive(false);
        }

        //chooseCar
        if (currState == UIStates.ChooseCar)
        {
            ChooseCar.SetActive(true);
        }
        else
        {
            ChooseCar.SetActive(false);
        }
    }


    //methods to change states
    public void SwitchToHome()
    {
        currState = UIStates.Home;
    }
    public void SwitchToEnvironment()
    {
        currState = UIStates.Environment;
    }

    public void SwitchToView()
    {
        currState = UIStates.View;
    }
    public void SwitchToLights()
    {
        currState = UIStates.Lights;
    }

    public void SwitchToMaterials()
    {
        currState = UIStates.Materials;
    }

    public void SwitchToChooseCar()
    {
        currState = UIStates.ChooseCar;
    }

}
