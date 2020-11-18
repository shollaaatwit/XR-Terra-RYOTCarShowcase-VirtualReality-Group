using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingController : MonoBehaviour
{

    public Light myLight; 
    public Light spotlight;

    public static Material matOne;
    public static Material matTwo;
    public static Material matThree;

    private static Color daytime = new Color(1f, 0.9568627f, 0.8392157f, 1f);
    private static Color evening = new Color(1f, 0.7836223f, 0.4575472f, 1f);
    private static Color night = new Color (0.4528302f, 0.4528302f, 0.4528302f, 1f);

    private void Start()
    {
 
    }

    public Material[] skyboxes = new Material[] {matOne, matTwo, matThree}; // holds array of skybox materials
    public Color[] lightColors = new Color[] {daytime, evening, night}; // holds different light colors

    public void SetEnvironment(int number) // changes skybox and lighting
    {
        RenderSettings.skybox = skyboxes[number];
        myLight.color = lightColors[number];
    }
    public void ChangeSpotLight(float input)
    {
        spotlight.intensity = Mathf.PingPong(Time.time, input);
    }
}
