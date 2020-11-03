using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Wood;
    public float SpawnRate = 1f;
    float nextSpawn = 0.0f;
    int enCount = 0;
    Vector3 SpawnPoint;
    float randX;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemies();
       
    }
    void SpawnEnemies()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = (Time.time) + SpawnRate;
            randX = Random.Range(-2f, 2f);
            SpawnPoint = new Vector3(randX, transform.position.y, 15f);
            Instantiate(Wood, SpawnPoint, Quaternion.Euler(0, 0, 90));
        }
    }
}