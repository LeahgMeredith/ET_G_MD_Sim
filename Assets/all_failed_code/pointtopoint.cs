using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointtopoint : MonoBehaviour
{
    [SerializeField] float remainingTime;
    [SerializeField] float remainingTimerad;


    int changeMovement = 1;

    [SerializeField] GameObject _redsquare;

    public float radnuma = 0;
    public float radnumb = 0;
  

    public float _speed;

    public Transform start;
    public Transform end;


    void Start()
    {

    }

  
    void Update()
    {

        Vector3 redsquarepos = _redsquare.transform.position;
        Vector3 zero = new Vector3(0, 0, 0);
        Vector3 target = new Vector3(zero.x + radnuma, zero.y + radnumb, zero.z);
        Vector3 ran = new Vector3(radnuma, radnumb, 0);

       
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

//everywhere redsquare is put mouse position

//int change_Destination_Flag = 0;
//int destination_1 = 0;
//int destination_2 = 100;
//int xyzPosition = 0;
//int space = 2;
//int primaryDest = 0;
//
//if (change_Destination_Flag == 1)
//{
//    if (xyzPosition >= space - destination_1)
//    {
//        primaryDest = destination_2;
//        change_Destination_Flag = 2;
//    }
//}

//if (change_Destination_Flag == 2)
//{
//    if (xyzPosition <= space + destination_2)
//    {
//        primaryDest = destination_1;
//        change_Destination_Flag = 1;
//    }
//}


//    if (destination_1 > destination_2){
//     space + destination_1;
//    }
//    if (destination_1 < destination_2){
//     space - destination_1;
//    }