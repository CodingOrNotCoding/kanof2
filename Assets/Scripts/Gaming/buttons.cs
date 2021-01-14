
using UnityEngine;


public class buttons : MonoBehaviour
{
    private float speed = 3f;

    void Start()
    {
       

    }
    void Update()
    {

        if (Input.GetKey(KeyCode.A) && transform.position.x >= -2.2f)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self); //LEFT
     
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 2.2f)
        {
       
            transform.Translate(Vector3.down * Time.deltaTime * speed, Space.Self); //RIGHT
        }
     
        if (Input.touchCount > 0)
        {
            // The screen has been touched so store the touch
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
            {
  
                transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self); //LEFT
            }
            if (touch.position.x > Screen.width / 2)
            {
          
                transform.Translate(Vector3.down * Time.deltaTime * speed, Space.Self); //RIGHT
            }
        }
      
    }
    }

