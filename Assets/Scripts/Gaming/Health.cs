using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    GameObject Kano;
    int health ;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        Kano = GameObject.FindGameObjectWithTag("Kano");
    }

    // Update is called once per frame
    void Update()
    {
        Dead();
    }
    void OnTriggerEnter(Collider Other)
    {
        if(Other.gameObject.tag == "Kano")
        {
            health = health - 1;
        }
    }
    void Dead()
    {
        if (health <= 0)
        {
            Destroy(Kano);
        }
        print(health);
    }
}
