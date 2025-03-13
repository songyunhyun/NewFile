using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlindActivatedController : MonoBehaviour
{
    public BlindController BlindController;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BlindController.activated)
                transform.position = new Vector3(transform.position.x, transform.position.y, -2);
        
        else
                transform.position = new Vector3(transform.position.x, transform.position.y, 11);
        
    }
}
