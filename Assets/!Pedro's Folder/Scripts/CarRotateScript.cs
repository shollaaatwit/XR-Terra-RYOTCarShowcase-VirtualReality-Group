using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotateScript : MonoBehaviour
{
    public Transform carPrefab;

    private Vector3 updateRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Vector3.SignedAngle(Vector3.forward , Vector3.zero, Vector3.up);

        updateRotation.y = angle;

    }

    public void Front()
    {
        Turn(90f);
    }
    public void Rear()
    {
        Turn(-90f);
    }
    public void Left()
    {
        Turn(0f);
    }

    public void Right()
    {
        Turn(180f);
    }

    public void FrontSide()
    {
        Turn(45);
    }

    public void RearSide()
    {
        Turn(-45);
    }
    public void sliderTurn(float input)
    {
        Turn(input);
    }

    private void Turn(float input)
    {
        updateRotation.y += input;
        carPrefab.localEulerAngles = updateRotation;

    }
}
