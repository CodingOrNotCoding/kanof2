using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    public float speed = 5f;

    private float cameray;


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
    private void Move()
    {
        Vector3 temp = transform.position;
        temp.y -= speed * Time.deltaTime;
        transform.position = temp;
    }
    public void Fast()
    {
        speed += 3f;
        
        print("FASTER!");
    }
    public void Slow()
    {
        if(speed > 5f)
        {
            speed -= 3f;
        }
        
        print("SLOWER!");
    }

    private void Position()
    {
        if (transform.position.y < cameray)
        {
          
            Vector3 temp = transform.position;
            temp.y = 25f;
            transform.position = temp;
            
        }
    }
}