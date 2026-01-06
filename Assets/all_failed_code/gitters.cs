using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gitters : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

  
    void SetTransformX(float a)
    {
        transform.position = new Vector3(a, transform.position.y, transform.position.z);
    }
    void SetTransformY(float b)
    {
        transform.position = new Vector3(transform.position.x, b, transform.position.z);
    }
    void SetTransformZ(float c)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, c);
    }


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
}
