﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 temp = transform.localPosition;
        temp.y -= speed * Time.deltaTime;
        transform.localPosition = temp;
    }
    public void Fast()
    {
        speed += 3f;
        print("FASTER!");
    }
    public void Slow()
    {
       
        if (speed > 5)
            speed -= 3f;
        print("SLOWER!");
    }
}
