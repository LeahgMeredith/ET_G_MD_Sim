using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refinedGitter : MonoBehaviour
{
    [SerializeField] float remainingTime;
    [SerializeField] float remainingTimerad;
    [SerializeField] float remainingTimeBeforePointReset;


    public int changeMovement = 1;

    [SerializeField] GameObject _redsquare;

    [SerializeField] private Camera maincamera;


    public float radnuma = 0;
    public float radnumb = 0;


    public float _speed;

    public float _movementspeed;

    public float _movementspeedback;

    public bool Movement = false;



    public Vector3 lastpos = new Vector3(0, 0, 0);

    //if mopving no if yes true
   
    void Start()
    {

    }


    void Update()
    {

        Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;
        Vector3 redsquarepos = _redsquare.transform.position;
        Vector3 zero = new Vector3(mp.x, mp.x, 0);
        Vector3 target = new Vector3(zero.x + radnuma, zero.y + radnumb, mp.z);
        Vector3 radius = new Vector3(mp.x + 2, mp.y + 2, mp.z);
       
        //if mouse pos is greater than last pos by 2 x or y, change is yess. if not no.

        transform.position = mp;



     //--------------------------------------------------------------------------------------------
        if(remainingTimeBeforePointReset > 0)
        {
            remainingTimeBeforePointReset -= Time.deltaTime;
        }

        if(remainingTimeBeforePointReset < 0)
        {
            remainingTimeBeforePointReset = 0;
        }

        if(remainingTimeBeforePointReset == 0)
        {
            lastpos = Input.mousePosition;

            remainingTimeBeforePointReset = 3;
        }


            if(Input.mousePosition.x > lastpos.x || Input.mousePosition.y > lastpos.y || Input.mousePosition.x < lastpos.x || Input.mousePosition.y < lastpos.y)
            {
                Movement = true;
            }

            if ( Input.mousePosition.x == lastpos.x || Input.mousePosition.y == lastpos.y)
            {
               _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, mp, _movementspeedback * Time.deltaTime);

                Movement = false;
            }
            //figure out why not moving sometimes 
      //---------------------------------------------------------------------------------

       //if(radnuma > 0 && radnuma < 0.2)
       // {
       //     _movementspeed = 11;
       // }

       //if (radnuma > 0.2 && radnuma < 0.3)
       // {
       //     _movementspeed = 9.5f;
       // }

       // if (radnuma > 0.3 && radnuma < 0.4)
       // {
       //     _movementspeed = 9;
       // }
         
       // if (radnuma > 0.4 && radnuma <= 0.5)
       // {
       //     _movementspeed = 8.5f;
       // }


        //-&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&-


        if (radnuma > 0 && radnuma < 0.04)
        {
            _movementspeedback = 14;
            _movementspeed = 15;
        }

        if (radnuma > 0.04 && radnuma < 0.08)
        {
            _movementspeedback = 12f;
            _movementspeed = 13;
        }

        if (radnuma > 0.08 && radnuma < 0.12)
        {
            _movementspeedback = 11;
            _movementspeed = 12;
        }

        if (radnuma > 0.12 && radnuma <= 0.2)
        {
            _movementspeedback = 10.5f;
            _movementspeed = 11;
        }

        //______________________________________________________________________

         if (radnuma > 0 && radnuma < -0.04)
        {
            _movementspeedback = 14;
            _movementspeed = 15;
        }

        if (radnuma > -0.04 && radnuma < -0.08)
        {
            _movementspeedback = 12f;
            _movementspeed = 13;
        }

        if (radnuma > -0.08 && radnuma < -0.12)
        {
            _movementspeedback = 11;
            _movementspeed = 12;
        }

        if (radnuma > -0.12 && radnuma <= -0.2)
        {
            _movementspeedback = 10.5f;
            _movementspeed = 11;
        }
        //-----------------------------------------------------------------------------
        //! if target number gets to be greater than a certain range around my mouse then admediatly return without nessiarily reaching the target. 

        if (remainingTime > 0)
        {

            remainingTime -= Time.deltaTime;
            remainingTimerad -= Time.deltaTime;

            
            if (Movement == true)
            {
                if (changeMovement == 1)
                {
                    // if (redsquarepos == zero || redsquarepos.x > target.x || redsquarepos.y > target.y)
                    // {
                    _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, target, _movementspeed * Time.deltaTime);
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
                    _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, mp, _movementspeedback * Time.deltaTime);
                    // }


                    if (redsquarepos == mp)
                    {
                        //!re-define currentpos with quartinants of mp. then check in if statement if currentpos and mp are the same. if true stop shaking if not keep going
                        //! if current pos is greater than 2, or something, thes
                        changeMovement = 4;
                    }
                }

                if (changeMovement == 4)
                {
                    radnuma = Random.Range(-0.2f, 0.2f);
                    radnumb = Random.Range(-0.03f, 0.07f);

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
               // radnuma = Random.Range(-1.0f, 1.0f);
               // radnumb = Random.Range(-0.5f, 0.5f);
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
