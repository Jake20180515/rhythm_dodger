﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManeger : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject Enemy;
    public GameObject Enemy1;
    public GameObject Enemy2;
    void SpawnEnemy()
    {
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(50f, 4.6f, 0f), Quaternion.identity);
        }
    }

    void SpawnEnemy1()
    {
        if (enableSpawn)
        {
            GameObject enemy1 = (GameObject)Instantiate(Enemy1, new Vector3(50f, 4.6f, 0f), Quaternion.identity);
        }
    }

    void SpawnEnemy2()
    {
        if (enableSpawn)
        {
            GameObject enemy2 = (GameObject)Instantiate(Enemy2, new Vector3(50f, 7f, 0f), Quaternion.identity);
        }
    }


    // Use this for initialization
    void Start () {
        Invoke("SpawnEnemy", 4.1f);
        Invoke("SpawnEnemy1", 5.4f);
        Invoke("SpawnEnemy2", 6.8f);
        Invoke("SpawnEnemy", 8.3f);
        Invoke("SpawnEnemy2", 9.6f);
        Invoke("SpawnEnemy1", 11f);
        Invoke("SpawnEnemy1", 12.4f);
        Invoke("SpawnEnemy2", 15.1f);
        Invoke("SpawnEnemy", 16.4f);
        Invoke("SpawnEnemy", 17.9f);
        Invoke("SpawnEnemy", 19.3f);
        Invoke("SpawnEnemy", 20.8f);
        Invoke("SpawnEnemy", 23.4f);
        Invoke("SpawnEnemy", 25.3f);
        Invoke("SpawnEnemy", 26.2f);
        Invoke("SpawnEnemy", 28.1f);
        Invoke("SpawnEnemy", 28.9f);
        Invoke("SpawnEnemy", 30.8f);
        Invoke("SpawnEnemy", 31.7f);
        Invoke("SpawnEnemy", 33.6f);
        Invoke("SpawnEnemy", 34.5f);
        Invoke("SpawnEnemy", 35.9f);
        Invoke("SpawnEnemy", 39.0f);
        Invoke("SpawnEnemy", 40.0f);
        Invoke("SpawnEnemy", 41.4f);
        Invoke("SpawnEnemy", 43.7f);
        Invoke("SpawnEnemy", 45.2f);
        Invoke("SpawnEnemy", 45.6f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
