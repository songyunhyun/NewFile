using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class aaaaa : MonoBehaviour
{
    public LightController LightController;
    public PlayerController PlayerController;
    public Light2D Light1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerController.transform.position.x, PlayerController.transform.position.y, transform.position.z);
        if (LightController.Light)
            Light1.pointLightOuterRadius = 99999;
        else
            Light1.pointLightOuterRadius = 15;



    }
}
