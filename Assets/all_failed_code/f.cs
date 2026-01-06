using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOLLOW : MonoBehaviour
{


    public GameObject _hand;

    public GameObject _ball;

    public GameObject _middle;


    public float _speed;

    int cool = 7;

    int beans = 4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cool == 7)
        {
            _hand.transform.position = Vector3.MoveTowards(_hand.transform.position, _ball.transform.position, _speed * Time.deltaTime);
        }

        if (cool == 5)
        {
            _hand.transform.position = Vector3.MoveTowards(_hand.transform.position, _middle.transform.position, _speed * Time.deltaTime);
        }

        void OnCollisonEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "ball1")
            {
                int cool = 6;
                int beans = 5;
            }

        }

        void OnCollisonExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "ball1")
            {
                int cool = 7;
                int beans = 4;
            }

        }
    }
}
