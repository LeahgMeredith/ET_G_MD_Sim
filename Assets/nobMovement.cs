using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nobMovement : MonoBehaviour
{

    public bool isInNobTrigger = false;



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "nob")
        {
            isInNobTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "nob")
        {
            isInNobTrigger = false;
        }
    }




    void Start()
    {
        
    }


    void Update()
    {
    }
}
