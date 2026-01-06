using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five : MonoBehaviour
{

    [SerializeField] float remainingTime;
    [SerializeField] float remainingTimerad;
    [SerializeField] float remainingTimeBeforePointReset;

    [SerializeField] float mouseSen;


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
    public Vector3 lastposHand = new Vector3(0, 0, 0);

    //if mopving no if yes true



    void Start()
    {

        Cursor.visible = false;

        //false mouse butt randomized poinnt go to instead of mouse itself. if spead get bigger,
        //butt closer to head. if not, farther away. ###########



        //I have encountered a problem; I cant make the hand gitter any larger because
        //its position is being defined too much.

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
    
    private void FixedUpdate()
    {
        Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;

        float mouseX = mp.x * mouseSen;
        float mouseY = mp.y * mouseSen;

        Vector3 MouseSlowed = new Vector3(mouseX, mouseY, 0);

       // transform.position = MouseSlowed;

    }

    void Update()
    {


        Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;

        float mouseX = mp.x * mouseSen;
        float mouseY = mp.y * mouseSen;

        Vector3 MouseSlowed = new Vector3(mouseX, mouseY, 0);

        // transform.position = MouseSlowed;





        Vector3 redsquarepos = _redsquare.transform.position;
        Vector3 zero = new Vector3(mp.x, mp.y, 0);
        Vector3 target = new Vector3(lastposHand.x + radnuma, lastposHand.y + radnumb, mp.z);
        Vector3 radiusBig = new Vector3(mp.x + 5f, mp.y + 5f, mp.z);




        //okay, so i tried redefinning the target to go to a place plus the hand value BUT i
        //am having a hard time getting it to look like its moving any larger no matter what.
        //i think it might be due to the fact i always have transformpos= mouseslowed on constantly.
        //maybe I can find a way to turn it off when we're twitching?




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
            lastposHand = redsquarepos;

            remainingTimeBeforePointReset = 3;
        }


        if (Input.mousePosition.x > lastpos.x || Input.mousePosition.y > lastpos.y || Input.mousePosition.x < lastpos.x || Input.mousePosition.y < lastpos.y)
        {
            Movement = true;
        }

        if (Input.mousePosition.x == lastpos.x && Input.mousePosition.y == lastpos.y)
        {

            Movement = false;
        }

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$Movement$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        if (radnuma > 0 && radnuma < 0.5)
        {
            _movementspeedback = 20;
            _movementspeed = 15;
        }

        if (radnuma > 0.5 && radnuma < 1)
        {
            _movementspeedback = 19f;
            _movementspeed = 13;
        }

        if (radnuma > 1 && radnuma < 2)
        {
            _movementspeedback = 18;
            _movementspeed = 12;
        }

        if (radnuma > 2 && radnuma < 2.5)
        {
            _movementspeedback = 17f;
            _movementspeed = 11;
        }

        if (radnuma > 2.5 && radnuma < 3)
        {
            _movementspeedback = 16f;
            _movementspeed = 11.5f;
        }

        if (radnuma > 3 && radnuma < 3.5)
        {
            _movementspeedback = 16.5f;
            _movementspeed = 12f;
        }

        if (radnuma > 3.5 && radnuma <= 4)
        {
            _movementspeedback = 17f;
            _movementspeed = 12.5f;
        }
        //______________________________________________________________________

        if (radnuma > 0 && radnuma < -0.5)
        {
            _movementspeedback = 20;
            _movementspeed = 15;
        }

        if (radnuma > -0.5 && radnuma < -1)
        {
            _movementspeedback = 19f;
            _movementspeed = 13;
        }

        if (radnuma > -1 && radnuma < -2)
        {
            _movementspeedback = 18;
            _movementspeed = 12;
        }

        if (radnuma > -2 && radnuma < -2.5)
        {
            _movementspeedback = 17f;
            _movementspeed = 11;
        }

        if (radnuma > -2.5 && radnuma < -3)
        {
            _movementspeedback = 16f;
            _movementspeed = 11.5f;
        }

        if (radnuma > -3 && radnuma < -3.5)
        {
            _movementspeedback = 16.5f;
            _movementspeed = 12f;
        }

        if (radnuma > -3.5 && radnuma <= -4)
        {
            _movementspeedback = 17f;
            _movementspeed = 12.5f;
        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$End_Of_Movement$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

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

                    _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, MouseSlowed, _movementspeedback * Time.deltaTime);

                    _redsquare.transform.rotation = Quaternion.RotateTowards(pointToRot, regularRot, _rotationSpeed * Time.deltaTime);



                    if (redsquarepos == MouseSlowed)
                    {
                        changeMovement = 1;
                    }
                }


            }

        }
        //change determinnance from last los of mous to last pos of object.
        // this will allow us to go back to it instead of mp

        //------------------------------------------------------------------------

        if (remainingTime < 0)
        {


            if (remainingTimerad < 0)
            {
                radForRot = Random.Range(-7f, 6f);
                radnuma = Random.Range(-4f, 4f);
                radnumb = Random.Range(-2f, 2f);
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
