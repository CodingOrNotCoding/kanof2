using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text HealthText;
    int health ;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }
    // Update is called once per frame
    void Update()
    {
        Dead();
        HealthText.text = (": " + health);
    }
  
    void OnTriggerEnter2D(Collider2D   other)
    {

        if (other.tag == "Enemies" && health>0)
        {  
                health = health - 1;
           
        }

    }
    void Dead()
    {
        if (health <= 0)
        {
            print("DİE!!!");
            SceneManager.LoadScene("diedscene");
        }
    }
 

}