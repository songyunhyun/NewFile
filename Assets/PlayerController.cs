using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 4f;
    public int Room_Number = 1;
    public GameManager CameraSwitch;
    int MoveMod = 0;//0=걷기, 1=달리기, 2=웅크리기
    public float stamina = 10.0f;
    public bool exhaustion = false;
    public float HP = 100;
    public float MP = 100;
    public bool dead = false;
    public SpriteRenderer Renderer;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            if (!CameraSwitch.WatchCCTV)
            {
                if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= 1)//좌측 이동
                {
                    if (exhaustion)//탈진 상태
                    {
                        transform.Translate(new Vector3(-Speed * Time.deltaTime * 0.5f, 0, 0));
                        stamina += 0.5f * Time.deltaTime;
                    }
                    else if (MoveMod == 0)//걷기
                    {
                        transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));
                        stamina += 0.5f * Time.deltaTime;
                    }
                    
                    else if (MoveMod == 1)//뛰기
                    {
                        if (stamina >= 0)
                        {
                            transform.Translate(new Vector3(-Speed * Time.deltaTime * 2, 0, 0));
                            stamina -= 1f * Time.deltaTime;
                        }
                        else//탈진
                            exhaustion = true;
                    }
                    else if (MoveMod == 2)//소리 죽여 걷기
                    {
                        transform.Translate(new Vector3(-Speed * Time.deltaTime * 0.5f, 0, 0));
                        stamina += 0.5f * Time.deltaTime;
                    }
                    //transform.localScale = new Vector3(-1, 1, 1);
                    Renderer.flipX = true;

                }
                else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 287)//우측 이동
                {
                    if (exhaustion)
                    {
                        transform.Translate(new Vector3(Speed * Time.deltaTime * 0.5f, 0, 0));
                        stamina += 0.5f * Time.deltaTime;
                    }
                    else if (MoveMod == 0)
                    {
                        transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0));
                        stamina += 0.5f * Time.deltaTime;
                    }
                    else if (MoveMod == 1)
                    {
                        if (stamina >= 0)
                        {
                            transform.Translate(new Vector3(Speed * Time.deltaTime * 2, 0, 0));
                            stamina -= 1f * Time.deltaTime;
                        }
                        else
                            exhaustion = true;
                    }
                    else if (MoveMod == 2)
                    {
                        transform.Translate(new Vector3(Speed * Time.deltaTime * 0.5f, 0, 0));
                        stamina += 0.5f * Time.deltaTime;

                    }
                    //transform.localScale = new Vector3(1, 1, 1);
                    Renderer.flipX = false;


                }
                else//안 움직이면 스테미나 회복량 두 배
                {
                    stamina += 1f * Time.deltaTime;
                }
            }


            else
            {
                stamina += 1f * Time.deltaTime;

            }

        }


        if (transform.position.x >= 0.5f && transform.position.x <= 47.5f)
            Room_Number = 1;
        else if (transform.position.x >= 48.5f && transform.position.x <= 95.5f)
            Room_Number = 2;
        else if (transform.position.x >= 96.5f && transform.position.x <= 143.5f)
            Room_Number = 3;
        else if (transform.position.x >= 144.5f && transform.position.x <= 191.5f)
            Room_Number = 4;
        else if (transform.position.x >= 192.5f && transform.position.x <= 239.5f)
            Room_Number = 5;
        else if (transform.position.x >= 240.5f && transform.position.x <= 287.5f)
            Room_Number = 6;
        /*
        else if (transform.position.x > 289.5f)
        {
            transform.position = new Vector3(1, transform.position.y, transform.position.z);
            Room_Number = 1;
        }
        else if (transform.position.x < -0.5f)
        {
            transform.position = new Vector3(287, transform.position.y, transform.position.z);
            Room_Number = 6;
        }
        */


        if (Input.GetKeyDown(KeyCode.LeftControl) && !exhaustion)//뛰기
        {
            if (MoveMod == 1)
                MoveMod = 0;
            else
                MoveMod = 1;
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) && !exhaustion)//소리 죽여 걷기
        {
            if (MoveMod == 2)
                MoveMod = 0;
            else
                MoveMod = 2;
        }
        else if (exhaustion)
        {
            MoveMod = 0;
        }

        if (stamina > 10)//최대치
            stamina = 10;

        if (stamina == 10 && exhaustion)//스태미나 꽉 채우면 탈진 상태 해제됨
            exhaustion = false;


        if (HP <= 0)
        {
            Debug.Log("HP Die");
            dead = true;
        }
        else if (MP <= 0)
        {
            Debug.Log("MP Die");
            dead = true;

        }
    }

}
