using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Clone;
    public float SpawnRate = 1f;
    float nextSpawn = 0.0f;
    Vector3 SpawnPoint;
    float randX;
    float cameray;

    // Start is called before the first frame update
    void Start()
    {
        
        cameray = Camera.main.gameObject.transform.position.y - 15f;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemies();
        Destroyed();
    }
    void SpawnEnemies()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = (Time.time) + SpawnRate;
            randX = Random.Range(-2f, 2f);
            SpawnPoint = new Vector3(randX, transform.position.y, 15f);
            Instantiate(Clone, SpawnPoint, Quaternion.Euler(0, 0, 0 ));

        }

       
    }
    void Destroyed()
    {
        if(GameObject.Find("Wood(Clone)").transform.position.y < cameray)
        Destroy(GameObject.Find("Wood(Clone)"), 0.2f);
        if (GameObject.Find("coin(Clone)").transform.position.y < cameray)
        Destroy(GameObject.Find("coin(Clone)"), 0.2f);
    }
}