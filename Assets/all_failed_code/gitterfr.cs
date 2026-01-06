using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gitterfr : MonoBehaviour
{
    [SerializeField] float remainingTime;
    [SerializeField] float remainingTimerad;
    

    [SerializeField] GameObject _redsquare;
    [SerializeField] GameObject _capsule;

    public float _speed;

    [SerializeField] private Camera maincamera;

    public Transform start;
    public Transform end;

    public float radnum = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float remainingTimerad = remainingTime;

       // Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
       // mp.z = 0f;
        
        //Vector3 target = new Vector3(mp.x + radnum, mp.y + radnum, mp.z);
        
        Vector3 cap = _capsule.transform.position;
        Vector3 target = new Vector3(cap.x + radnum, cap.y + radnum, 0);

        //-----------------------------------------------------------------------
        //maybe instead of have the thing come back to the position of the mouse have it come back to something following the mouse

        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            remainingTimerad -= Time.deltaTime;



            _redsquare.transform.position = Vector3.MoveTowards(_capsule.transform.position, target, _speed * Time.deltaTime);

            //_redsquare.transform.position = Vector3.MoveTowards(mp, target, _speed * Time.deltaTime);

           // if (_redsquare.transform.position == target)
          //  {
          //      _redsquare.transform.position = Vector3.MoveTowards(target, _capsule.transform.position, _speed * Time.deltaTime);
               // _redsquare.transform.position = Vector3.MoveTowards(target, mp, _speed * Time.deltaTime);

          //  }
           // if (_redsquare.transform.position != maincamera.ScreenToWorldPoint(Input.mousePosition))
           // {
           //     transform.position = maincamera.ScreenToWorldPoint(Input.mousePosition);
           // }

        }

        if (remainingTime < 0)
        {
            if(remainingTimerad < 0)
            {
                remainingTimerad = 0;
            }

            if(remainingTimerad == 0)
            {
                radnum = Random.Range(-5f, 5f);
                remainingTimerad = remainingTime;
            }
           
           // if(_redsquare.transform.position == mp)
            
             remainingTime = 0;
            
           
        }

        if (remainingTime == 0)
        {
            remainingTime = 2;
        }
    }
}

//everywhere redsquare is put mouse position
