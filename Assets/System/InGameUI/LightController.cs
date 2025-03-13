using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public bool Light = true;
    public Sprite OnLight;
    public Sprite OffLight;
    public GameManager cameraSwitch;
    Image img;
    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (cameraSwitch.WatchCCTV)
        {
            Light = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                if (Light)//끄기
                {
                    Light = false;
                }
                else//켜기
                {
                    Light = true;
                }
            }

            if (Light)
            {
                img.sprite = OnLight;
            }
            else
            {
                img.sprite = OffLight;
            }
        }
    }
}
