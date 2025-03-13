using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Camera MainCamera;
    public Camera CCTV;
    public bool WatchCCTV = false;
    public BlindController Blind;
    public Image Eye;
    public PlayerController PlayerController;
    public int CCTV_RoomNumber;
    void Start()
    {
        if (MainCamera != null)
            MainCamera.gameObject.SetActive(true);
        if (CCTV != null)
            CCTV.gameObject.SetActive(false);

        Eye.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        { //ESC∏¶ ¥≠∑∂¿ª∂ß
            Application.Quit(); //∞‘¿”/æ€ ¡æ∑·.
        }
        */




        if (Blind.activated)
        {
            WatchCCTV = false;
            Eye.gameObject.SetActive(true);


        }
        else
        {
            Eye.gameObject.SetActive(false);

            /*
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if (WatchCCTV)
                {
                    WatchCCTV = false;
                }
                else
                {
                    WatchCCTV = true;
                }
            }
            */

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (WatchCCTV && CCTV_RoomNumber == 1)
                    WatchCCTV = false;
                else
                {
                CCTV_RoomNumber = 1;
                WatchCCTV = true;
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (WatchCCTV && CCTV_RoomNumber == 2)
                    WatchCCTV = false;
                else
                {
                    CCTV_RoomNumber = 2;
                    WatchCCTV = true;
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (WatchCCTV && CCTV_RoomNumber == 3)
                    WatchCCTV = false;
                else
                {
                    CCTV_RoomNumber = 3;
                    WatchCCTV = true;
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (WatchCCTV && CCTV_RoomNumber == 4)
                    WatchCCTV = false;
                else
                {
                    CCTV_RoomNumber = 4;
                    WatchCCTV = true;
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                if (WatchCCTV && CCTV_RoomNumber == 5)
                    WatchCCTV = false;
                else
                {
                    CCTV_RoomNumber = 5;
                    WatchCCTV = true;
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                if (WatchCCTV && CCTV_RoomNumber == 6)
                    WatchCCTV = false;
                else
                {
                    CCTV_RoomNumber = 6;
                    WatchCCTV = true;
                }
            }


            if (!WatchCCTV)
            {
                if (MainCamera != null)
                    MainCamera.gameObject.SetActive(true);
                if (CCTV != null)
                    CCTV.gameObject.SetActive(false);

            }
            else
            {
                if (MainCamera != null)
                    MainCamera.gameObject.SetActive(false);
                if (CCTV != null)
                    CCTV.gameObject.SetActive(true);
            }
        }
    }
}
