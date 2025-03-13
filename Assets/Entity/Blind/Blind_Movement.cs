using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blind_Movement : MonoBehaviour
{
    float speed = 2;
    float startWaitTime;
    float waitTime;
    float xx;
    Vector3 movespot;
    void Start()
    {
        transform.position = new Vector3(Random.Range(49.0f, 287.0f), transform.position.y, transform.position.z);
        xx = Random.Range(-40.0f, 40.0f);
        movespot = new Vector3(transform.position.x + xx, transform.position.y, transform.position.z);
        startWaitTime = Random.Range(0.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, movespot, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, movespot) < 0.2)
        {
            if (waitTime <= 0)
            {
                movespot = new Vector3(transform.position.x + xx, transform.position.y, transform.position.z);
                startWaitTime = Random.Range(0.0f, 10.0f);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }


        if (transform.position.x > 288)
            movespot.x = -movespot.x + 288;
        else if (transform.position.x < 0)
            movespot.x = -movespot.x;
        /*
        if (transform.position.x > 289.5f)
        {
            transform.position = new Vector3(1, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -0.5f)
        {
            transform.position = new Vector3(287, transform.position.y, transform.position.z);
        }
        */
    }
}
