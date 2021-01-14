using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject Clone;
    private float SpawnRate = 1f;
    float nextSpawn = 0.0f;
    private Vector3 SpawnPoint;
    private float randX;
    private float cameray;
    private bool stopped = false;
    static int coRain;
    static int block;
    private int coin;
    public Text rained;
    public Text blocked;
    // Start is called before the first frame update
    void Start()
    {
        coRain= PlayerPrefs.GetInt("rains");
        block = PlayerPrefs.GetInt("Blocks");
        cameray = Camera.main.gameObject.transform.position.y - 15f;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemies();
        Destroyed();
        rained.text = ("rain: " + coRain);
        blocked.text = ("block: " + block);
    }

    private void SpawnEnemies()
    {
        if (Time.time > nextSpawn && !stopped)
        {
            nextSpawn = (Time.time) + SpawnRate;
            randX = Random.Range(-2f, 2f);
            SpawnPoint = new Vector3(randX, transform.position.y, 15f);
            Instantiate(Clone, SpawnPoint, Quaternion.Euler(0, 0, 0 ));
        }
    }

    private void beNormal()
    {
        SpawnRate = 1f;
        print("Normal");
        stopped = false;
    }

    public void rain()
    {
        if (coRain > 0)
        {
            SpawnRate = 0.05f;
            Invoke("beNormal", 7);
            coRain--;
            PlayerPrefs.SetInt("rains", coRain);
        }
    }
   public void stop()
    {
        if (block > 0)
        {
            stopped = true;
            Invoke("beNormal", 10);
            block--;
            PlayerPrefs.SetInt("Blocks", block);
        }
    }
    public void rainBuy()
    {
        coin= PlayerPrefs.GetInt("myCoins");
        if (coin >= 25)
        {
            ++coRain;
            PlayerPrefs.SetInt("rains", coRain);
        }
       
    }

    public void stopBuy()
    {
        coin = PlayerPrefs.GetInt("myCoins");
        if (coin >= 25)
        {
            ++block;
            PlayerPrefs.SetInt("Blocks", block);
        }
       
    }

    private void Destroyed()
    {
        if(GameObject.Find("Wood(Clone)").transform.position.y < cameray)
        Destroy(GameObject.Find("Wood(Clone)"), 0.2f);
        if (GameObject.Find("coin(Clone)").transform.position.y < cameray)
        Destroy(GameObject.Find("coin(Clone)"), 0.2f);
    }
}