using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private Camera maincamera;
    [SerializeField] GameObject _cube;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 me = _cube.transform.position;
        Vector3 target = mp;
        mp.z = 0;
        transform.position =mp ;
        //transform.position = mp; current, target, how fast
        //could just use movetowards btw maybe not really
        
    }
}