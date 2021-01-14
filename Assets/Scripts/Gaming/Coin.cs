using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coin : MonoBehaviour
{
    public Text coin;
    public Text coin1;
    public static int coins;
    void Start()
    {
        coins= PlayerPrefs.GetInt("myCoins");
        coin.text = (": " + coins);
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Coins")
        {
            
            coins = ++coins;
            PlayerPrefs.SetInt("myCoins", coins);
            coin.text = ("= " + coins);
        }
    }

    public void jokerBuy()
    {
        if (coins >= 25)
        {
            coins = coins - 25;
            PlayerPrefs.SetInt("myCoins", coins);
        }
        
      
    }
    public void swordBuy()
    {
        if (coins >= 250)
        {
            coins = coins - 250;
            PlayerPrefs.SetInt("myCoins", coins);
        }


    }
    // Update is called once per frame
    void Update()
    {
        coin1.text = (" " + coins);
    }
}
