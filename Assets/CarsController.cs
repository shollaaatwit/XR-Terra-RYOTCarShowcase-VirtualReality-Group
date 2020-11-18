using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsController : MonoBehaviour
{

    public GameObject[] carPrefabs;
    public Transform spawnLocation;

    public void SpawnCar(int carNum)
   {
       Instantiate(carPrefabs[carNum], spawnLocation);
   }

    public void ChangeCar(int carNum)
    {
        foreach (Transform child in spawnLocation)
        {
            GameObject.Destroy(child.gameObject);
        }
        SpawnCar(carNum);
    }
}
