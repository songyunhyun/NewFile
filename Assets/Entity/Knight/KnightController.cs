using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
{
    public GameObject slash;
    float startWaitTime = 0.25f;
    float waitTime;
    float SlashWaitTime;
    float SlashStartWaitTime = 0.5f;
    public PlayerController PlayerController;

    void Start()
    {
        int a = Random.Range(2, 7);
        transform.position = new Vector3(a * 48 - 24, transform.position.y, transform.position.z);
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (SlashWaitTime <= 0 && !PlayerController.dead)
            {
                Instantiate(slash, new Vector3(collision.transform.position.x, collision.transform.position.y + 1, collision.transform.position.z - 1), Quaternion.identity);
                PlayerController.HP -= 100;
                SlashWaitTime = SlashStartWaitTime;
            }
            else
                SlashWaitTime -= Time.deltaTime;



            if (waitTime <= 0)
            {
                GameObject g = GameObject.Find("Slash1_Red(Clone)");
                if (g != null)
                {
                    Destroy(g);
                }
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

            

        }

    }
}
