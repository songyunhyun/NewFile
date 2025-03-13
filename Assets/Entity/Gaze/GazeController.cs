using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GazeController : MonoBehaviour
{
    public PlayerController playerController;
   // public BlindController blindController;
    public LightController lightController;
    public Image image;
    public float startWateTime;
    public float wateTime;
    public int activatedLevel;
    public bool activated;
    int roomNumber;
    public float a;//≈ı∏Ìµµ
    int darkness;
    float coolDownSpeed = 1;
    void Start()
    {
        //image = GetComponent<Image>();
        startWateTime = Random.Range(20, 31);
        wateTime = startWateTime;
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
            coolDownSpeed = 1 * darkness;

            if (!lightController.Light)// || blindController.activated)
                darkness = 4;
            else
                darkness = 1;


            if (wateTime <= 0)
            {
                activated = true;
                playerController.MP -= 10;
                roomNumber = playerController.Room_Number;
                wateTime = 10 - activatedLevel;
                activatedLevel++;
                a += 5f / 255f;
                image.color = new Color(image.color.r, image.color.g, image.color.b, a);
            }
            else
            {
                wateTime -= Time.deltaTime * coolDownSpeed;
            }

            if (activated && roomNumber != playerController.Room_Number)
            {
                activated = false;
                //playerController.MP += 5;
                startWateTime = Random.Range(20, 31);
                wateTime = startWateTime;
                activatedLevel = 0;
                a = 0;
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
            }
        }


    }
}
