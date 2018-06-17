using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3Spawn : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject Enemy;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    // Use this for initialization
    void SpawnEnemy()
    {
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(50f, 1.6f, 0f), Quaternion.identity);
        }
    }

    void SpawnEnemy1()
    {
        if (enableSpawn)
        {
            GameObject enemy1 = (GameObject)Instantiate(Enemy1, new Vector3(50f, 6f, 0f), Quaternion.identity);
        }
    }

    void SpawnEnemy2()
    {
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(50f, 4.6f, 0f), Quaternion.identity);
        }
    }

    void SpawnEnemy3()
    {
        if (enableSpawn)
        {
            GameObject enemy1 = (GameObject)Instantiate(Enemy1, new Vector3(50f, 18f, 0f), Quaternion.identity);
        }
    }

    void SpawnEnemy4()
    {
        if (enableSpawn)
        {
            GameObject enemy2 = (GameObject)Instantiate(Enemy2, new Vector3(50f, 4.6f, 0f), Quaternion.identity);
        }
    }

    void SpawnEnemy5()
    {
        if (enableSpawn)
        {
            GameObject enemy3 = (GameObject)Instantiate(Enemy3, new Vector3(50f, 7f, 0f), Quaternion.identity);
        }
    }

    void Start()
    {
        Invoke("SpawnEnemy4", 0.6f);
        Invoke("SpawnEnemy5", 2.4f);
        Invoke("SpawnEnemy", 3.0f);
        Invoke("SpawnEnemy1", 3.9f);
        Invoke("SpawnEnemy", 5.8f);
        Invoke("SpawnEnemy1", 6.4f);
        Invoke("SpawnEnemy3", 7.3f);
        Invoke("SpawnEnemy", 7.3f);
        Invoke("SpawnEnemy", 8.2f);
        Invoke("SpawnEnemy3", 9.1f);
        Invoke("SpawnEnemy", 9.1f);
        Invoke("SpawnEnemy1", 10.1f);
        Invoke("SpawnEnemy5", 11.6f);
        Invoke("SpawnEnemy4", 12.2f);
        Invoke("SpawnEnemy", 13.6f);
        Invoke("SpawnEnemy1", 14.0f);
        Invoke("SpawnEnemy", 15.0f);
        Invoke("SpawnEnemy2", 15.8f);
        Invoke("SpawnEnemy4", 18.4f);
        Invoke("SpawnEnemy3", 20.1f);
        Invoke("SpawnEnemy", 20.1f);
        Invoke("SpawnEnemy5", 20.9f);
        Invoke("SpawnEnemy", 21.8f);
        Invoke("SpawnEnemy1", 22.5f);
        Invoke("SpawnEnemy3", 23.5f);
        Invoke("SpawnEnemy", 23.5f);
        Invoke("SpawnEnemy", 25.3f);
        Invoke("SpawnEnemy2", 26.1f);
        Invoke("SpawnEnemy4", 27.0f);
        Invoke("SpawnEnemy2", 27.8f);
        Invoke("SpawnEnemy", 31.2f);
        Invoke("SpawnEnemy1", 31.7f);
        Invoke("SpawnEnemy3", 32.8f);
        Invoke("SpawnEnemy", 32.8f);
        Invoke("SpawnEnemy5", 33.8f);
        Invoke("SpawnEnemy4", 35.6f);
        Invoke("SpawnEnemy", 37.2f);
        Invoke("SpawnEnemy2", 38.1f);
        Invoke("SpawnEnemy1", 39.8f);
        Invoke("SpawnEnemy4", 40.6f);
        Invoke("SpawnEnemy", 41.5f);
        Invoke("SpawnEnemy5", 42.4f);
    }
}
