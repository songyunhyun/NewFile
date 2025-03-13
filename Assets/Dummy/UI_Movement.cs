using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UI_Movement : MonoBehaviour
{
    public PlayerController PlayerController;
    public GameManager CameraSwitch;
    float xxx = 0;
    float Speed;
    public Vector3 xyz;
    public Vector3 xyz_Scale;
    int Room_Number2;
    void Start()
    {
        xxx += xyz.x + 24;
        Room_Number2 = PlayerController.Room_Number;
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraSwitch.WatchCCTV)
            transform.localScale = new Vector3(0, 0, 0);
        else if (!CameraSwitch.WatchCCTV && transform.localScale.z == 0)
            transform.localScale = xyz_Scale;


        if (PlayerController.transform.position.x < ((PlayerController.Room_Number * 48) - 9) && PlayerController.transform.position.x > (((PlayerController.Room_Number - 1) * 48) + 9))//플레이어가 가장자리에 있는 게 아니면 플레이어 따라감
            transform.position = new Vector3(PlayerController.transform.position.x + xyz.x, transform.position.y, transform.position.z);

        else if (PlayerController.transform.position.x > ((PlayerController.Room_Number * 48) - 2))//플레이어가 방 넘어가면 쫒아감
            transform.position = new Vector3((PlayerController.Room_Number * 48) - 9 + xyz.x, transform.position.y, transform.position.z);

        else if (PlayerController.transform.position.x < (((PlayerController.Room_Number - 1) * 48) + 2))//=
            transform.position = new Vector3(((PlayerController.Room_Number - 1) * 48) + 9 + xyz.x, transform.position.y, transform.position.z);






        /*
        Speed = PlayerController.Speed;


        if (CameraSwitch.WatchCCTV)
            transform.localScale = new Vector3(0, 0, 0);
        else if (!CameraSwitch.WatchCCTV && transform.localScale.z == 0)
            transform.localScale = xyz_Scale;

        if (xxx < ((PlayerController.Room_Number * 48) - 9 + xyz.x) && xxx > (((PlayerController.Room_Number - 1) * 48) + 9 + xyz.x))
            transform.position = new Vector3(xxx, transform.position.y, transform.position.z);

        if (Input.GetKey(KeyCode.LeftArrow))
            xxx -= Speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.RightArrow))
            xxx += Speed * Time.deltaTime;


        
        if (PlayerController.Room_Number != Room_Number2)
        {
            if (PlayerController.Room_Number > Room_Number2)
            {
                if (PlayerController.Room_Number - Room_Number2 == 5)
                    transform.position = new Vector3(PlayerController.transform.position.x + xyz.x - 9, PlayerController.transform.position.y + xyz.y + 1, xyz.z);
                else
                    transform.position = new Vector3(PlayerController.transform.position.x + xyz.x + 9, PlayerController.transform.position.y + xyz.y + 1, xyz.z);

                Room_Number2 = PlayerController.Room_Number;
                xxx = PlayerController.transform.position.x + xyz.x;
            }


            else
            {
                if (PlayerController.Room_Number - Room_Number2 == -5)
                    transform.position = new Vector3(PlayerController.transform.position.x + xyz.x + 9, PlayerController.transform.position.y + xyz.y + 1, xyz.z);
                else
                    transform.position = new Vector3(PlayerController.transform.position.x + xyz.x - 9, PlayerController.transform.position.y + xyz.y + 1, xyz.z);

                Room_Number2 = PlayerController.Room_Number;
                xxx = PlayerController.transform.position.x + xyz.x;
            }

        }
        */

    }
}
