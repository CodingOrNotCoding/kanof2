using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    public float speed = 5f;

    private float cameray;
    private float Height;

    void Start()
    {
        cameray = Camera.main.gameObject.transform.position.y - 15f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Position();
    }
    void Move()
    {
        Vector3 temp = transform.position;
        temp.y -= speed * Time.deltaTime;
        transform.position = temp;
    }

    void Position()
    {
        if (transform.position.y < cameray)
        {
          
            Vector3 temp = transform.position;
            temp.y = 25f;
            transform.position = temp;
            
        }
    }
}
