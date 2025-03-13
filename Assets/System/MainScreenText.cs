using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreenText : MonoBehaviour
{
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, new Vector3(0, 0, 0), 0);
            /*
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics2D.Raycast
            */
            if (hit.collider != null)
            {

                if (hit.collider.tag == "Start")
                {
                    SceneManager.LoadScene("LevelSelect");
                }
                else if (hit.collider.tag == "Option")
                {
                    //SceneManager.LoadScene("LevelSelect");¹Ì±¸Çö
                }
                else if (hit.collider.tag == "Exit")
                {
                    Application.Quit();
                }
            }
        }
    }
}
