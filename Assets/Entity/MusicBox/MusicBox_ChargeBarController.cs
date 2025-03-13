using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicBox_ChargeBarController : MonoBehaviour
{
    public MusicBoxController musicBoxController;
    public PlayerController playerContoroller;
    public GameManager gameManager;
    public Image img;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (playerContoroller.Room_Number == 1 || (gameManager.WatchCCTV && gameManager.CCTV_RoomNumber == playerContoroller.Room_Number))
            img.enabled = true;
        else
            img.enabled = false;


        img.fillAmount = musicBoxController.charge / 60;
    }
}
