using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindController : MonoBehaviour
{
    public PlayerController playerController;
    public bool activated;
    public int Room_Number2 = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Room_Number2 == playerController.Room_Number)
        {
            activated = true;
        }
        else
        {
            activated = false;
        }

        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Room1")
        {
            Room_Number2 = 1;
        }
        if (collision.gameObject.tag == "Room2")
        {
            Room_Number2 = 2;
        }
        if (collision.gameObject.tag == "Room3")
        {
            Room_Number2 = 3;
        }
        if (collision.gameObject.tag == "Room4")
        {
            Room_Number2 = 4;
        }
        if (collision.gameObject.tag == "Room5")
        {
            Room_Number2 = 5;
        }
        if (collision.gameObject.tag == "Room6")
        {
            Room_Number2 = 6;
        }
    }
}
