using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gittermore : MonoBehaviour
{

    int interpolationFramesCount = 240;
    int elapsedFrames = 0;

    [SerializeField] float remainingTime;
    

    public float radnum = 0;

   // public Transform target;
  //  public float smoothtimeduation = 0.3f;

    private Vector3 velocity = Vector3.zero;
   // private float velocity = 0f;

 

    [SerializeField] private Camera maincamera;

    private void Start()
    {
      
        
    }

    private void Update()
    {
       // radnum = Random.Range(-1f, 1f);
       
        

        if(remainingTime > 0)
        { remainingTime -= Time.deltaTime; Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition); mp.z = 0f; transform.position = mp; }

        if (remainingTime < 0)
        {
            remainingTime = 0;
            radnum = Random.Range(-5f, 5f);
           
           
            Vector3 mp = maincamera.ScreenToWorldPoint(Input.mousePosition);
            mp.z = 0f;

         
            float ranx = radnum + mp.x;
            float rany = radnum + mp.y;
            //^our target
            Vector3 target = new Vector3(ranx, rany, 0);

            elapsedFrames = (elapsedFrames + 1) % (interpolationFramesCount + 1);

            float interpolationRatio = (float)elapsedFrames / interpolationFramesCount;

            if (radnum >= 1.5f)
            {
                interpolationRatio = interpolationRatio % radnum;
            }

            Vector3 interpolatedPosition = Vector3.Lerp(mp, target, interpolationRatio);

            transform.position = interpolatedPosition;

            if (transform.position == interpolatedPosition)
            {
                Vector3 interpolatedPositionBack = Vector3.Lerp(target, mp, interpolationRatio);
                transform.position = interpolatedPositionBack;
            }


           // transform.position = Vector3.SmoothDamp(mp, target, ref velocity, smoothtimeduation);
           //remainingTime = 2;
           // give it a way back
        }
       
   

        if (remainingTime == 0)
        {
            remainingTime = 5f;
        }











        // if (doOnce == true)
        //{
        //     transform.position = Vector3.SmoothDamp(mp, target, ref velocity, smoothtimeduation);
        //   doOnce = false;
        // }

        // if(mp == target)
        // {
        //    transform.position = Vector3.SmoothDamp(mp, target, ref velocity, smoothtimeduation);
        //}
        //transform.position = Vector3.SmoothDamp(mp, yup, ref velocity, smoothtimeduation);
        //mp.x = Mathf.SmoothDamp(mp.x, fish, ref velocity, smoothtimeduation);
        //mp.y = Mathf.SmoothDamp(mp.y, fishy, ref velocity, smoothtimeduation);





        // transform.position = Vector3.SmoothDamp(mp.y, radnum, ref velocity, smoothtimeduation);

        // transform.position = mp;

        //  transform.position = new Vector3(h, g, mp.z);


        //  Vector3 bug = transform.position + mp;

        // StartCoroutine(Example());
        //  IEnumerator Example()
        // {
        //    yield return new WaitForSecondsRealtime(2);
        // }


        // if (imjustheretokeepitgoing == true)
        //  {

        //    if (transform.position == mp)
        //    {
        //   radnum = Random.Range(1f, 5f);
        //  }
        // if (transform.position == bug)
        //{
        //     transform.position = mp;
        // }

        //try redfining the target
        //at one time, the mouse location is the target
        //at another, the traget is the random interval around the mouse
        //lerp these values and have something that is a timer that will also be random mp.y is target
        //  }
    }
}
