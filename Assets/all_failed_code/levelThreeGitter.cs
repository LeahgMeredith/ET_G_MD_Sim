using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelThreeGitter : MonoBehaviour
{

    [SerializeField] float remainingTime;
    [SerializeField] float remainingTimerad;
    [SerializeField] float remainingTimeBeforePointReset;


    public int changeMovement = 1;

    [SerializeField] GameObject _redsquare;

    [SerializeField] private Camera maincamera;

    public float radForRot = 0;
    public float radnuma = 0;
    public float radnumb = 0;

    public float _gobackquick = 16;

    public float _rotationSpeed = 5;

    public float _speed;

    public float _movementspeed;

    public float _movementspeedback;

    public bool Movement = false;



    public Vector3 lastpos = new Vector3(0, 0, 0);

    //if mopving no if yes true





    void Start()
    {


        ////to do----
        //okay, now that we have this working, I'm going to decrease sensitivity to make
        //it harder to move to the object. I'm also gonna mak it so that you will have to hold for a certain
        // amount of time before you pick the object up. ALSO I'm gonna have it so there is a small chance
        // you drop what youre holding as your shaking progresses.

        //big problem 1== ???? no fixed. it was that I doubble defined zero as (x, x, z) LOL
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
       // transform.position = mp;

        Vector3 redsquarepos = _redsquare.transform.position;
        Vector3 zero = new Vector3(mp.x, mp.y, 0);
        Vector3 target = new Vector3(zero.x + radnuma, zero.y + radnumb, mp.z);
        Vector3 radius = new Vector3(mp.x + 5f, mp.y + 5f, mp.z);


       
            
      
       


        //rotation--------------------------------------------------------------

        Quaternion regularRot = _redsquare.transform.rotation;
        Quaternion pointToRot = Quaternion.Euler(0, 0, radForRot);




        //if you need it, bring it back===(not apart of rotation)
        // if (redsquarepos.x > radius.x || redsquarepos.y > radius.y)
        // {
        //     _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, mp, _gobackquick * Time.deltaTime);
        //  }


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

        if (radnuma > 0 && radnuma < 0.25)
        {
            _movementspeedback = 20;
            _movementspeed = 15;
        }

        if (radnuma > 0.25 && radnuma < 0.5)
        {
            _movementspeedback = 19f;
            _movementspeed = 13;
        }

        if (radnuma > 0.5 && radnuma < 0.75)
        {
            _movementspeedback = 18;
            _movementspeed = 12;
        }

        if (radnuma > 0.75 && radnuma < 1)
        {
            _movementspeedback = 17f;
            _movementspeed = 11;
        }

        if (radnuma > 1 && radnuma <= 2)
        {
            _movementspeedback = 16f;
            _movementspeed = 11.5f;
        }
        //______________________________________________________________________

        if (radnuma > 0 && radnuma < -0.25)
        {
            _movementspeedback = 20;
            _movementspeed = 15;
        }

        if (radnuma > -0.25 && radnuma < -0.5)
        {
            _movementspeedback = 19f;
            _movementspeed = 13;
        }

        if (radnuma > -0.5 && radnuma < -0.75)
        {
            _movementspeedback = 18;
            _movementspeed = 12;
        }

        if (radnuma > -0.75 && radnuma < -1)
        {
            _movementspeedback = 17f;
            _movementspeed = 11;
        }

        if (radnuma > -1 && radnuma <= -2)
        {
            _movementspeedback = 16f;
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

                    _redsquare.transform.rotation = Quaternion.RotateTowards(regularRot, pointToRot, _rotationSpeed * Time.deltaTime);

                    if (redsquarepos == target)
                    {

                        changeMovement = 2;
                    }
                }

                if (changeMovement == 2)
                {

                    _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, mp, _movementspeedback * Time.deltaTime);

                    _redsquare.transform.rotation = Quaternion.RotateTowards( pointToRot, regularRot, _rotationSpeed * Time.deltaTime);



                    if (redsquarepos == mp)
                    {
                        changeMovement = 1;
                    }
                }

            }

        }

        //------------------------------------------------------------------------

        if (remainingTime < 0)
        {


            if (remainingTimerad < 0)
            {
                radForRot = Random.Range(-4, 4);
                radnuma = Random.Range(-2f, 2f);
               radnumb = Random.Range(-0.2f, 0.4f);
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
