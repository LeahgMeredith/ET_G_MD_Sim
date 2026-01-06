using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    /// <summary>
    /// attach this to barF
    /// </summary>
    private GlowComands glowComands;
    bool _touching1 = false;
    bool _touching2 = false;


    void Start()
    {
        glowComands = GetComponent<GlowComands>();

        if (glowComands != null)
        {
            Debug.Log("Day value from GlowComands: " + glowComands.Day);
        }
    }



    void Update()
    {
        if (glowComands.Day == 1)
        {

        }

        if(_touching1 == true && _touching2 == true)
        {
            glowComands.ProgressionProgress = glowComands.ProgressionProgress - 2;
            glowComands.NobInMotion = false;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "goalBar1")
        {
            _touching1 = true;
        }
        if (collision.gameObject.tag == "goalBar2")
        {
            _touching1 = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "goalBar1")
        {
            _touching1 = false;
        }

        if (collision.gameObject.tag == "goalBar2")
        {
            _touching2 = false;
        }
    }



}
