using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public PlayerController PlayerController;
    Image image;
    float open;
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.dead)
        {
            open += 0.5f * Time.deltaTime;
            image.color = new Color(image.color.r, image.color.g, image.color.b, open);
        }
    }
}
