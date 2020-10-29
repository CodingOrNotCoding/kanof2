using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
    float speed = 3f;
    void Start()
    {
      
    }
 
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self); //LEFT
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed, Space.Self); //RIGHT
        }
        
       
    }
    public void OnLeft()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self); //LEFT
    }
    public void OnRight()
    {

        transform.Translate(Vector3.down * Time.deltaTime * speed, Space.Self); //RIGHT
    }
}
