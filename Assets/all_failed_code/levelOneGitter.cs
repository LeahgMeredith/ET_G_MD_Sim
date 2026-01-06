using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelOneGitter : MonoBehaviour
{
    [SerializeField] float remainingTime;
    [SerializeField] float remainingTimerad;
    [SerializeField] float remainingTimeBeforePointReset;


    public int changeMovement = 1;

    [SerializeField] GameObject _redsquare;

    [SerializeField] private Camera maincamera;


    public float radnuma = 0;
    public float radnumb = 0;

    public float _gobackquick = 16;

    public float _speed;

    public float _movementspeed;

    public float _movementspeedback;

    public bool Movement = false;



    public Vector3 lastpos = new Vector3(0, 0, 0);

    //if mopving no if yes true





    void Start()
    {

    //big problem 1== ????
        //we have a problem, when I add a number to mousposition, mp, it compounds like=
        // lets say we at 5, then it goes 5 plus 5+2 which adds WAY too much.
        //Im trying to think of a way to just make it transform 2 away from our point,
        //not compound. Rn target needs a whole overhall. Maybe I can create a whole new vector/ point
        //for it to go to after I add the radnuma to the current point? Ill try it
    }


    void Update()
    {

        Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;
      //  transform.position = mp;

        Vector3 redsquarepos = _redsquare.transform.position;
        Vector3 zero = new Vector3(mp.x, mp.y, 0);
        Vector3 target = new Vector3(zero.x + radnuma, zero.y + radnumb, mp.z);
        Vector3 radius = new Vector3(mp.x + 5f, mp.y + 5f, mp.z);

        

        if(redsquarepos.x > radius.x || redsquarepos.y > radius.y)
        {
            _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, mp, _gobackquick * Time.deltaTime);
        }


        //--------------------------------------------------------------------------------------------

        if (remainingTimeBeforePointReset > 0)
        {
            remainingTimeBeforePointReset -= Time.deltaTime;
        }

        if (remainingTimeBeforePointReset < 0)
        {
            remainingTimeBeforePointReset = 0;
        }

        if (remainingTimeBeforePointReset == 0)
        {
            lastpos = Input.mousePosition;

            remainingTimeBeforePointReset = 3;
        }


        if (Input.mousePosition.x > lastpos.x || Input.mousePosition.y > lastpos.y || Input.mousePosition.x < lastpos.x || Input.mousePosition.y < lastpos.y)
        {
            Movement = true;
        }

        if (Input.mousePosition.x == lastpos.x && Input.mousePosition.y == lastpos.y)
        {
            _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, mp, _movementspeedback * Time.deltaTime);

            Movement = false;
        }
       
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        if (radnuma > 0 && radnuma < 0.01)
        {
            _movementspeedback = 14;
            _movementspeed = 15;
        }

        if (radnuma > 0.01 && radnuma < 0.02)
        {
            _movementspeedback = 12f;
            _movementspeed = 13;
        }

        if (radnuma > 0.02 && radnuma < 0.035)
        {
            _movementspeedback = 11;
            _movementspeed = 12;
        }

        if (radnuma > 0.035 && radnuma < 0.04)
        {
            _movementspeedback = 10.5f;
            _movementspeed = 11;
        }

        if (radnuma > 0.04 && radnuma <= 0.05)
        {
            _movementspeedback = 11f;
            _movementspeed = 11.5f;
        }
        //______________________________________________________________________

        if (radnuma > 0 && radnuma < -0.01)
        {
            _movementspeedback = 14;
            _movementspeed = 15;
        }

        if (radnuma > -0.01 && radnuma < -0.02)
        {
            _movementspeedback = 12f;
            _movementspeed = 13;
        }

        if (radnuma > -0.02 && radnuma < -0.035)
        {
            _movementspeedback = 11;
            _movementspeed = 12;
        }

        if (radnuma > -0.035 && radnuma < -0.04)
        {
            _movementspeedback = 10.5f;
            _movementspeed = 11;
        }

        if (radnuma > -0.04 && radnuma <= -0.05)
        {
            _movementspeedback = 11f;
            _movementspeed = 11.5f;
        }
        //-----------------------------------------------------------------------------

        if (remainingTime > 0)
        {

            remainingTime -= Time.deltaTime;
            remainingTimerad -= Time.deltaTime;


            if (Movement == true)
            {
                if (changeMovement == 1)
                {
                   
                    _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, target, _movementspeed * Time.deltaTime);
                  

                    if (redsquarepos == target)
                    {

                        changeMovement = 2;
                    }
                }

                if (changeMovement == 2)
                {
                   
                    _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, mp, _movementspeedback * Time.deltaTime);
                   

                    if (redsquarepos == mp)
                    {
                        changeMovement = 4;
                    }
                }

                if (changeMovement == 4)
                {
                   // radnuma = Random.Range(-0.05f, 0.05f);
                   // radnumb = Random.Range(-0.02f, 0.04f);

                    changeMovement = 1;
                }
            }

        }

        //------------------------------------------------------------------------

        if (remainingTime < 0)
        {


            if (remainingTimerad < 0)
            {
                radnuma = Random.Range(-0.05f, 0.05f);
                radnumb = Random.Range(-0.02f, 0.04f);
                remainingTimerad = 0;
            }


            if (remainingTimerad == 0)
            {
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
