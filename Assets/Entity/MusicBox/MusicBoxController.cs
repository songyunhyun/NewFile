using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxController : MonoBehaviour
{
    public InterractionController interractionController;
    public PlayerController playerController;
    public MusicBox_ActivatedController musicBox_ActivatedController;
    public float charge;
    public bool activated = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (interractionController.Interracted && !activated && charge < 60)
        {
            charge += 4 * Time.deltaTime;
            playerController.MP -= 0.5f * Time.deltaTime;
        }
        else
        {
            charge -= 1 * Time.deltaTime;
        }

        if (charge <= 0)
        {
            activated = true;
            musicBox_ActivatedController.gameObject.SetActive(true);
            charge = 0;
        }
        else if (charge > 60)
        {
            charge = 60;
        }
    }
}
