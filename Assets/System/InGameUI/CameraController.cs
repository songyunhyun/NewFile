using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController PlayerController;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.transform.position.x < ((PlayerController.Room_Number * 48) - 14.25f) && PlayerController.transform.position.x > (((PlayerController.Room_Number - 1) * 48) + 14.25f))//플레이어가 가장자리에 있는 게 아니면 플레이어 따라감
            transform.position = new Vector3(PlayerController.transform.position.x, transform.position.y, -10);

        else if (PlayerController.transform.position.x > ((PlayerController.Room_Number * 48) - 2))//플레이어가 방 넘어가면 쫒아감
            transform.position = new Vector3((PlayerController.Room_Number * 48) - 14.25f, transform.position.y, -10);

        else if (PlayerController.transform.position.x < (((PlayerController.Room_Number - 1) * 48) + 2))//=
            transform.position = new Vector3(((PlayerController.Room_Number - 1) * 48) + 14.25f, transform.position.y, -10);
    }
}
