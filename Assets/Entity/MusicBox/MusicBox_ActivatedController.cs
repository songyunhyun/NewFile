using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBox_ActivatedController : MonoBehaviour
{
    public PlayerController playerController;
    public MusicBoxController musicBoxController;
    public SpriteRenderer sprite;
    void Start()
    {
        transform.position =new Vector3(musicBoxController.transform.position.x, musicBoxController.transform.position.y + 1, musicBoxController.transform.position.z - 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (musicBoxController.activated)
        {
            if (transform.position.x < playerController.transform.position.x)
                sprite.flipX = true;
            else
                sprite.flipX = false;

            transform.position = Vector2.MoveTowards(transform.position, playerController.transform.position, 32 * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            playerController.MP -= 100;
            musicBoxController.charge = 60;
            musicBoxController.activated = false;
            Destroy(gameObject);
        }
    }
}
