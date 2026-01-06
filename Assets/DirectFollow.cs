using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//useless
public class DirectFollow : MonoBehaviour
{
    private GlowComands glowComands;
    private NewestJitter newestJitter;

    [SerializeField] GameObject _redsquare;

    [SerializeField] private Camera maincamera;

    void Start()
    {
        glowComands = GetComponent<GlowComands>();

        if (glowComands != null)
        {
            Debug.Log("Day value from GlowComands: " + glowComands.Day);
        }

        newestJitter = GetComponent<NewestJitter>();

        if (newestJitter != null)
        {
            Debug.Log("day1, so no shaking.");
        }
    }


    void Update()
    {
        if (glowComands.Day > 1)
        {
            newestJitter.enabled = true;
        }
        
            

        if (glowComands.Day == 1)
        {
            newestJitter.enabled = false;
            Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
            Vector3 redsquarepos = mp;
            _redsquare.transform.position = redsquarepos;
        }
        
    }
}
