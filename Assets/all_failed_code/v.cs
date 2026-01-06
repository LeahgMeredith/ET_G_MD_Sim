using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v : MonoBehaviour
{
    Vector3 whereitat = new Vector3 ( -2, -3, 0);
    Vector3 whereitwas = new Vector3(1, 5, 0);
    public float smoothtimeduation = 0.3f;
    public Transform target;
    private Vector3 velocity = Vector3.zero;


    [SerializeField] private Camera maincamera;

    void Update()
    {
        
      //  Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);

        //transform.position = mp;

        transform.position = Vector3.SmoothDamp(whereitwas, whereitat, ref velocity, smoothtimeduation);

    }
}
