using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1Spawn : MonoBehaviour {
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


    // Use this for initialization
    void Start()
    {
        Invoke("SpawnEnemy", 0.6f);
        Invoke("SpawnEnemy1", 2.1f);
        Invoke("SpawnEnemy2", 3.4f);
        Invoke("SpawnEnemy", 4.8f);
        Invoke("SpawnEnemy2", 6.2f);
        Invoke("SpawnEnemy1", 9.0f);
        Invoke("SpawnEnemy1", 10.3f);
        Invoke("SpawnEnemy2", 11.8f);
        Invoke("SpawnEnemy3", 14.5f);
        Invoke("SpawnEnemy", 14.5f);
        Invoke("SpawnEnemy", 15.8f);
        Invoke("SpawnEnemy", 17.2f);
        Invoke("SpawnEnemy1", 18.7f);
        Invoke("SpawnEnemy", 20.0f);
        Invoke("SpawnEnemy", 21.4f);
        Invoke("SpawnEnemy2", 22.4f);
        Invoke("SpawnEnemy", 22.9f);
        Invoke("SpawnEnemy3", 24.6f);
        Invoke("SpawnEnemy", 24.6f);
        Invoke("SpawnEnemy1", 26.5f);
        Invoke("SpawnEnemy3", 27.4f);
        Invoke("SpawnEnemy", 28.3f);
        Invoke("SpawnEnemy2", 30.1f);
        Invoke("SpawnEnemy", 31.1f);
        Invoke("SpawnEnemy3", 32.9f);
        Invoke("SpawnEnemy", 33.8f);
        Invoke("SpawnEnemy", 35.2f);
        Invoke("SpawnEnemy2", 38.3f);
        Invoke("SpawnEnemy1", 39.4f);
        Invoke("SpawnEnemy", 40.7f);
        Invoke("SpawnEnemy3", 41.8f);
        Invoke("SpawnEnemy", 43.2f);
        Invoke("SpawnEnemy2", 44.5f);
        Invoke("SpawnEnemy2", 46.3f);
        Invoke("SpawnEnemy", 48.5f);
        Invoke("SpawnEnemy1", 49.6f);
        Invoke("SpawnEnemy", 50.0f);
        Invoke("SpawnEnemy2", 51.3f);
        Invoke("SpawnEnemy", 52.3f);
        Invoke("SpawnEnemy3", 54.1f);
        Invoke("SpawnEnemy", 55.6f);
        Invoke("SpawnEnemy", 56.2f);
        Invoke("SpawnEnemy3", 57.4f);
        Invoke("SpawnEnemy", 57.4f);
        Invoke("SpawnEnemy", 58.8f);
        Invoke("SpawnEnemy1", 60.2f);
        Invoke("SpawnEnemy", 61.6f);
        Invoke("SpawnEnemy2", 63.0f);
        Invoke("SpawnEnemy", 64.4f);
        Invoke("SpawnEnemy", 67.1f);
        Invoke("SpawnEnemy3", 68.5f);
        Invoke("SpawnEnemy", 69.9f);
        Invoke("SpawnEnemy", 71.3f);
        Invoke("SpawnEnemy1", 72.6f);
        Invoke("SpawnEnemy", 74.2f);
        Invoke("SpawnEnemy2", 75.5f);
        Invoke("SpawnEnemy", 78.2f);
        Invoke("SpawnEnemy2", 79.5f);
        Invoke("SpawnEnemy", 80.5f);
        Invoke("SpawnEnemy3", 81.0f);
        Invoke("SpawnEnemy", 81.0f);
        Invoke("SpawnEnemy", 82.3f);
        Invoke("SpawnEnemy1", 83.7f);
        Invoke("SpawnEnemy", 85.0f);
        Invoke("SpawnEnemy2", 86.4f);
        Invoke("SpawnEnemy", 88.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
