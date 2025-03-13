using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVController : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.WatchCCTV)
        {
            transform.position = new Vector3(gameManager.CCTV_RoomNumber * 48 - 24, transform.position.y, transform.position.z);






            /*
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (transform.position.x < 264)
                {
                    transform.position = new Vector3(transform.position.x + 48, 0, -10);
                }
                else
                {
                    transform.position = new Vector3(24, 0, -10);
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (transform.position.x > 24)
                {
                    transform.position = new Vector3(transform.position.x - 48, 0, -10);
                }
                else
                {
                    transform.position = new Vector3(264, 0, -10);
                }
            }
            */



        }
    }
}
