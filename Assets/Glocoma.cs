using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glocoma : MonoBehaviour
{

    public static Glocoma instance;

    void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
    
}