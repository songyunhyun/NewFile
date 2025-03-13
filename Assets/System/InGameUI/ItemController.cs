using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public InterractionController InterractionController;
    public HotBarController HotBarController1;
    public HotBarController HotBarController2;
    public HotBarController HotBarController3;
    public Vector3 Size;
    public float weight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (InterractionController.Interracted)
        {
            if (!HotBarController1.filed)
            {
                transform.position = new Vector3(HotBarController1.transform.position.x, HotBarController1.transform.position.y, transform.position.z);
                transform.localScale = Size;
                transform.localRotation = Quaternion.Euler(0, 0, -45);
            }
            else if (!HotBarController2.filed)
            {
                transform.position = new Vector3(HotBarController2.transform.position.x, HotBarController2.transform.position.y, transform.position.z);
                transform.localScale = Size;
                transform.localRotation = Quaternion.Euler(0, 0, -45);
            }
            else if (!HotBarController2.filed)
            {
                transform.position = new Vector3(HotBarController3.transform.position.x, HotBarController3.transform.position.y, transform.position.z);
                transform.localScale = Size;
                transform.localRotation = Quaternion.Euler(0, 0, -45);
            }
            else
            {
                InterractionController.Interracted = false;
            }
        }

    }
}
