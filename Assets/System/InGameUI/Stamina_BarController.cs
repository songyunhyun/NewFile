using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina_BarController : MonoBehaviour
{
    public PlayerController PlayerController;
    Image img;
    public Sprite Stamina_Bar_image1;
    public Sprite Stamina_Bar_image2;
    void Start()
    {
        img  = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (CameraSwitch.WatchCCTV)
            Stamina_Bar.SetActive(false);//셋 액티브=나타났다 사라지게 하기 true면 나타남, false면 사라짐
        else
            Stamina_Bar.SetActive(true);
        */


        if (PlayerController.exhaustion && PlayerController.stamina < 0.01f)
        {
            img.sprite = Stamina_Bar_image2;
        
            //GetComponent<SpriteRenderer>().sprite = Stamina_Bar_image2;
        }
        else if (!PlayerController.exhaustion && PlayerController.stamina == 10)
        {
            //GetComponent<SpriteRenderer>().sprite = Stamina_Bar_image1;
            img.sprite = Stamina_Bar_image1;

        }
        img.fillAmount = PlayerController.stamina / 10;




       
    }
}
