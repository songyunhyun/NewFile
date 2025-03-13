using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class ClearController : MonoBehaviour
{
    public int stage;
    float wateTime;
    public int startWateTime;
    public Clear_Screen clear_Screen;
    public TextMeshProUGUI clearText;
    public PlayerController playerController;
    int a;
    void Start()
    {
        Debug.Log(startWateTime);
        wateTime = startWateTime;
        Debug.Log(wateTime.ToString());
        clearText.text = wateTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.dead)
        {
            Destroy(gameObject);
        }
        else
        {
            if (stage == 0)
            {
                if (wateTime <= 0)
                {
                    clear_Screen.gameObject.SetActive(true);
                }
                else
                {
                    wateTime -= Time.deltaTime;
                    a = (int)Math.Ceiling(wateTime);
                    clearText.text = a.ToString();
                }
            }
        }
    }
}
