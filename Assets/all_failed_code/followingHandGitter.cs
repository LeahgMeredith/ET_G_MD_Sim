using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingHandGitter : MonoBehaviour
{
    [SerializeField] float remainingTime;
    [SerializeField] float remainingTimerad;


    public int changeMovement = 1;

    [SerializeField] GameObject _redsquare;

    [SerializeField] private Camera maincamera;


    public float radnuma = 0;
    public float radnumb = 0;


    public float _speed;
    


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
       
       
        
        transform.position = mp;

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
                _redsquare.transform.position = Vector3.MoveTowards(redsquarepos, mp, _speed * Time.deltaTime);
                // }


                if (redsquarepos == mp)
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
                radnuma = Random.Range(-1.0f, 1.0f);
                radnumb = Random.Range(-1.0f, 1.0f);
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
