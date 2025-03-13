using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VainKillerController : MonoBehaviour
{
    public PlayerController playerController;
    public SpriteRenderer sprite;
    public bool activated;
    int room_Number;
    public LightController lightController;
    bool direction = true;//true:오 false:왼
    void Start()
    {
        float a = Random.Range(49.0f, 288.0f);
        transform.position = new Vector3(a, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (room_Number == playerController.Room_Number && lightController.Light)
            activated = true;
        else
            activated = false;



        if (activated)
        {
            if (transform.position.x < playerController.transform.position.x)
            {
                sprite.flipX = false;
                direction = true;
            }
                

            else
            {
                sprite.flipX = true;
                direction = false;
            }


            transform.position = Vector2.MoveTowards(transform.position, playerController.transform.position, 10 * Time.deltaTime);
        }
        else
        {
            if (direction)//오른쪽 이동
            {
                sprite.flipX = false;
                transform.position = new Vector3(transform.position.x + (4 * Time.deltaTime), transform.position.y, transform.position.z);
                if (transform.position.x >= 288)
                {
                    direction = false;
                }
            }
            else
            {
                sprite.flipX = true;
                transform.position = new Vector3(transform.position.x + (-4 * Time.deltaTime), transform.position.y, transform.position.z);
                if (transform.position.x <= 0)
                {
                    direction = true;
                }
            }
        }
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Room1")
        {
            room_Number = 1;
        }
        if (collision.gameObject.tag == "Room2")
        {
            room_Number = 2;
        }
        if (collision.gameObject.tag == "Room3")
        {
            room_Number = 3;
        }
        if (collision.gameObject.tag == "Room4")
        {
            room_Number = 4;
        }
        if (collision.gameObject.tag == "Room5")
        {
            room_Number = 5;
        }
        if (collision.gameObject.tag == "Room6")
        {
            room_Number = 6;
        }



        if (collision.gameObject.tag == "Player" && activated)
        {
            playerController.HP -= 100;
        }

    }
}
