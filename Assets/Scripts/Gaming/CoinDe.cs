using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Kano")
            Destroy(gameObject);        
    }
}
