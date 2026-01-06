using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickisnewzero : MonoBehaviour
{
    [SerializeField] float remainingTime;
    [SerializeField] float remainingTimerad;
    [SerializeField] float remainingT;


    int changeMovement = 1;

    [SerializeField] GameObject _redsquare;
    [SerializeField] private Camera maincamera;

[SerializeField] Vector3 zero = new Vector3(0, 0, 0);

    public float radnuma = 0;
    public float radnumb = 0;

    public int key = 1;

    public float _speed;

    


    void Start()
    {

    }


    void Update()
    {
        Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;

        Vector3 redsquarepos = _redsquare.transform.position;
        
        Vector3 target = new Vector3(zero.x + radnuma, zero.y + radnumb, zero.z);

        if (key == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                zero = mp;
                key = 2;
            }
        }

        if(key == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                remainingT -= Time.deltaTime;

                if (remainingT <= 0)
                {
                    if ((Input.GetKeyDown(KeyCode.Space)))
                    {
                        remainingT = 0.001f;
                        key = 1; 
                    }
                }
            }
        }

        
        if (remainingTime > 0)
        {

            remainingTime -= Time.deltaTime;
            remainingTimerad -= Time.deltaTime;



            if (changeMovement == 1)
            {
                // if (redsquarepos == zero || redsquarepos.x > target.x || redsquarepos.y > target.y)
                // {
                _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, target, _speed * Time.deltaTime);
                // }


                if (redsquarepos == target)
                {

                    changeMovement = 2;
                }
            }

            if (changeMovement == 2)
            {
                //if (redsquarepos == target || redsquarepos.x < zero.x || redsquarepos.y < zero.y)
                //  {
                _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, zero, _speed * Time.deltaTime);
                // }


                if (redsquarepos == zero)
                {

                    changeMovement = 1;
                }
            }


        }




        //------------------------------------------------------------------------
        if (remainingTime < 0)
        {


            if (remainingTimerad < 0)
            {
                remainingTimerad = 0;
            }


            if (remainingTimerad == 0)
            {
                radnuma = Random.Range(-5.0f, 5.0f);
                radnumb = Random.Range(-5.0f, 5.0f);
                remainingTimerad = remainingTime;
            }


            remainingTime = 0;




        }


        //----------------------------------------------------------------------
        if (remainingTime == 0)
        {

            remainingTime = 2;

        }
    }
}
