using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterractionController : MonoBehaviour
{
    public GameObject Interraction_UI;
    public GameManager gameManager;
    bool madeUI = false;
    public bool Interracted = false;
    public float lenght;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (gameManager.WatchCCTV)
        {
            GameObject g = GameObject.Find("Interaction_UI(Clone)");
            if (g != null)
            {
                Destroy(g);
            }
            madeUI = false;
            Interracted = false;
        }
        else
        {


            RaycastHit2D[] hit = Physics2D.RaycastAll(new Vector3(transform.position.x - (lenght / 2), transform.position.y, transform.position.z), Vector2.right, lenght);





            Debug.Log(collision);
            if (collision.gameObject.tag == "Player")
            {
                if (!madeUI)
                {
                    Instantiate(Interraction_UI, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
                    madeUI = true;
                }
            }
            if (Input.GetKey(KeyCode.F) && collision.gameObject.tag == "Player")
            {
                Debug.Log("333");
                Interracted = true;
                Debug.Log("interracted");
            }
            else
                Interracted = false;

        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject g = GameObject.Find("Interaction_UI(Clone)");
            if (g != null)
            {
                Destroy(g);
            }
            madeUI = false;
        }
            
        
    }
}
