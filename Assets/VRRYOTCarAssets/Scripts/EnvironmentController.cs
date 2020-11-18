using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{

    public static GameObject environment1;
    public static GameObject environment2;
    public static GameObject environment3;

    public GameObject[] environments = new GameObject[] {environment1, environment2, environment3};

    void Start()
    {
        environments[0].gameObject.SetActive(true);
        environments[1].gameObject.SetActive(false);
        environments[2].gameObject.SetActive(false);
    }

    public void ChangeEnvironment(int number)
    {
        switch(number)
        {
            case 0:
                environments[0].gameObject.SetActive(true);
                environments[1].gameObject.SetActive(false);
                environments[2].gameObject.SetActive(false);
                break;
            case 1:
                environments[0].gameObject.SetActive(false);
                environments[1].gameObject.SetActive(true);
                environments[2].gameObject.SetActive(false);
                break;
            case 2:
                environments[0].gameObject.SetActive(false);
                environments[1].gameObject.SetActive(false);
                environments[2].gameObject.SetActive(true);
                break;
            default:
                break;
        }

    }
}
