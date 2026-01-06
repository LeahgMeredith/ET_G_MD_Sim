using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewestJitter : MonoBehaviour
{
    private GlowComands glowComands;
    private DirectFollow directFollow;



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

    

    public float _movementspeed;

    public float _movementspeedback;

    public bool Movement = false;



    public Vector3 lastpos = new Vector3(0, 0, 0);
    public Vector3 lastposHand = new Vector3(0, 0, 0);


    //---------------------------------------------------------------------

    [SerializeField] private float shakeCooldown = 2f; 
    private float shakeCooldownTimer = 0f;

    private bool isShaking = false;

    //---------------------------------------------------------------------

    void Start()
    {

        glowComands = GetComponent<GlowComands>();

        if (glowComands != null)
        {
            Debug.Log("Day value from GlowComands: " + glowComands.Day);
        }

        directFollow = GetComponent<DirectFollow>();

        if (directFollow != null)
        {
            Debug.Log(" value from DirectFollow");
        }



        Cursor.visible = false;
    }

    //---------------------------------------------------------------------
    void Update()
    {
        

        //if day == day1(ex) {mouse sen = (whatever needed)}@@@@@@



        Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;

        float mouseX = mp.x * mouseSen;
        float mouseY = mp.y * mouseSen;

        Vector3 MouseSlowed = new Vector3(mouseX, mouseY, 0);

        Vector3 redsquarepos = _redsquare.transform.position;
     
        Vector3 target = new Vector3(lastposHand.x + radnuma, lastposHand.y + radnumb, mp.z);


        //rotation------------->
        Quaternion regularRot = _redsquare.transform.rotation;
        Quaternion pointToRot = Quaternion.Euler(0, 0, radForRot);
        //--------------------------------------------------------------------------end

        //movement+timeBeforeNextPointReset--------------->

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
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            
                remainingTimeBeforePointReset = 0.5f;
           
        }


        if (Input.mousePosition.x > lastpos.x || Input.mousePosition.y > lastpos.y || Input.mousePosition.x < lastpos.x || Input.mousePosition.y < lastpos.y)
        {
            Movement = true;
        }

        if (Input.mousePosition.x == lastpos.x && Input.mousePosition.y == lastpos.y)
        {

            Movement = false;
        }



        //-----------------------------------------------------radio->
        if(glowComands.NobInMotion == true)
        {
            Movement = false;
        }
        //--------------------------------------------------------------------end




        //WhenToMove(2, 3, 4)-------------->

        if (shakeCooldownTimer > 0f)
        {
            shakeCooldownTimer -= Time.deltaTime;
        }
      
        if (glowComands.Day == 2 || glowComands.Day == 3 )
        {
            if (isShaking == false && shakeCooldownTimer <= 0f && Movement == true)
            {
                // Start shaking
                isShaking = true;
                changeMovement = 1;
            }

            if (isShaking == true)
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
                        // Finished one shake cycle
                        isShaking = false;
                        shakeCooldownTimer = shakeCooldown; // reset the timer
                    }
                }
            }
        }




        //WhenToMove(1)-------------->

        if (remainingTime > 0)
        {

            remainingTime -= Time.deltaTime;
            remainingTimerad -= Time.deltaTime;


            if (glowComands.Day == 1 || glowComands.Day == 2 || glowComands.Day == 3)
            {
                if (Movement == true)
                {

                    Vector3 mouseWorldPos = maincamera.ScreenToWorldPoint(Input.mousePosition);
                    _redsquare.transform.position = new Vector3(mouseWorldPos.x * mouseSen, mouseWorldPos.y * mouseSen, 0);

                }
            }



            if (glowComands.Day == 5 || glowComands.Day == 4)
            {
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
        }



//------------------------------------------------------------------------------

       

      
        if (glowComands.Day == 1)
        {
            //i dont think day 1 here really matters but keep it anyway

            mouseSen = 1f;

            _movementspeedback = 25f;
            _movementspeed = 25;
        }

        if (glowComands.Day == 1.5)
        {
            shakeCooldown = 0.6f;
            mouseSen = 0.9f;//--0.8

            if (radnuma > 0.015 && radnumb > 0.015 || radnuma < -0.015 && radnumb < -0.015)
            {
                _movementspeedback = 18f;
                _movementspeed = 18;
            }

            if (radnuma < 0.015 && radnumb < 0.015 || radnuma > -0.015 && radnumb > -0.015)
            {
                _movementspeedback = 19f;
                _movementspeed = 19;
            }

        }

        if (glowComands.Day == 3)
        {

            shakeCooldown = 0.2f;
            mouseSen = 0.8f;//was 0.8 ->//--0.45

            if (radnuma > 0.3 && radnumb > 0.2 || radnuma < -0.3 && radnumb < -0.2)
            {
                _movementspeedback = 15f;
                _movementspeed = 17;
            }

            if (radnuma < 0.3 && radnumb < 0.2 || radnuma > -0.3 && radnumb > -0.2)
            {
                _movementspeedback = 12f;
                _movementspeed = 14;
            }

            
        }

        if (glowComands.Day == 4)
        {//change completely
            shakeCooldown = 0.02f;
            mouseSen = 0.65f;//--0.3

            if (radnuma > 0.35 && radnumb > 0.3 || radnuma < -0.35 && radnumb < -0.3)
            {
                _movementspeedback = 15f;
                _movementspeed = 17;
            }

            if (radnuma < 0.35 && radnumb < 0.3 || radnuma > -0.35 && radnumb > -0.3)
            {
                _movementspeedback = 12f;
                _movementspeed = 14;
            }
        }

        if (glowComands.Day == 5)
        {
            shakeCooldown = 0.0001f;
            mouseSen = 0.58f;//--0.3

            if (radnuma > 0.4 && radnumb > 0.4 || radnuma < -0.4 && radnumb < -0.4)
            {
                _movementspeedback = 19f;
                _movementspeed = 20;
            }

            if (radnuma < 0.4 && radnumb < 0.4 || radnuma > -0.4 && radnumb > -0.4)
            {
                _movementspeedback = 20f;
                _movementspeed = 21;
            }
        }


        if (remainingTime < 0)
        {

            if (remainingTimerad < 0)
            {

                ///nothing looks right yet lol


                //if day == day1(ex) {rad(ex) = (whatever needed)}
                //remember youre gonna need more for if they screw it up + this is just for hands
                if (glowComands.Day == 1)
                {
                    ////////
                    radForRot = 0;
                    radnuma = 0;
                    radnumb = 0;
                    
                }

                if (glowComands.Day == 2)
                {
                    radForRot = Random.Range(-0.5f, 0.5f);
                    radnuma = Random.Range(-0.4f, 0.4f);
                    radnumb = Random.Range(-0.3f, 0.3f);
                    
                }

                if (glowComands.Day == 3)
                {
                    radForRot = Random.Range(-1f, 1f);
                    radnuma = Random.Range(-0.6f, 0.6f);
                    radnumb = Random.Range(-0.5f, 0.5f);
                }

                if (glowComands.Day == 4)
                {
                    //change
                    radForRot = Random.Range(-1f, 1f);
                    radnuma = Random.Range(-0.7f, 0.7f);
                    radnumb = Random.Range(-0.6f, 0.6f);
                }

                if (glowComands.Day == 5)
                {
                    //false

                    radForRot = Random.Range(-1f, 1f);
                    radnuma = Random.Range(-0.8f, 0.8f);
                    radnumb = Random.Range(-0.8f, 0.8f);
                }



                remainingTimerad = 0;


                //radForRot = Random.Range(-7f, 6f);
                //radnuma = Random.Range(-1f, 1f);
                //radnumb = Random.Range(-0.5f, 0.5f);
                //remainingTimerad = 0;
            }


            if (remainingTimerad == 0)
            {
                remainingTimerad = remainingTime;
            }


            remainingTime = 0;

        }


        
        if (remainingTime == 0)
        {
            
                remainingTime = 0.3f;
       
        }


        ////--------------------------------------------------------------------

        
       
        //end_of_update---------------------------------------------------------
    }
}
