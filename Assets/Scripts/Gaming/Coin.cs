using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coin : MonoBehaviour
{
    public Text coin;
    private int coins;
    void Start()
    {
        coins = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Coins")
        {
            
            coins = coins + 1;
            print(coins);
            coin.text = ("= "+ coins);
        }

    }
    // Update is called once per frame
    void Update()
    { 
    }
}
