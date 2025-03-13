using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HP_BarController : MonoBehaviour
{
    public PlayerController PlayerController;
    
    Image img;
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        img.fillAmount = PlayerController.HP / 100;
    }
}
