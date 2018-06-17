using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2Spawn : MonoBehaviour {
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

    // Use this for initialization
    void Start () {
        Invoke("SpawnEnemy", 0.6f);
        Invoke("SpawnEnemy2", 2.2f);
        Invoke("SpawnEnemy", 3.3f);
        Invoke("SpawnEnemy1", 4.8f);
        Invoke("SpawnEnemy2", 5.7f);
        Invoke("SpawnEnemy1", 6.6f);
        Invoke("SpawnEnemy2", 7.7f);
        Invoke("SpawnEnemy", 8.7f);
        Invoke("SpawnEnemy3", 10.0f);
        Invoke("SpawnEnemy0", 10.0f);
        Invoke("SpawnEnemy", 11.2f);
        Invoke("SpawnEnemy4", 12.3f);
        Invoke("SpawnEnemy", 14.9f);
        Invoke("SpawnEnemy1", 15.8f);
        Invoke("SpawnEnemy", 17.3f);
        Invoke("SpawnEnemy2", 18.4f);
        Invoke("SpawnEnemy2", 18.9f);
        Invoke("SpawnEnemy", 19.4f);
        Invoke("SpawnEnemy5", 21.1f);
        Invoke("SpawnEnemy", 22.9f);
        Invoke("SpawnEnemy1", 23.6f);
        Invoke("SpawnEnemy3", 24.7f);
        Invoke("SpawnEnemy", 25.7f);
        Invoke("SpawnEnemy2", 26.5f);
        Invoke("SpawnEnemy4", 27.7f);
        Invoke("SpawnEnemy2", 28.1f);
        Invoke("SpawnEnemy", 29.2f);
        Invoke("SpawnEnemy1", 30.1f);
        Invoke("SpawnEnemy3", 32.1f);
        Invoke("SpawnEnemy1", 32.9f);
        Invoke("SpawnEnemy2", 33.6f);
        Invoke("SpawnEnemy", 34.5f);
        Invoke("SpawnEnemy2", 35.5f);
        Invoke("SpawnEnemy1", 37.3f);
        Invoke("SpawnEnemy2", 39.0f);
        Invoke("SpawnEnemy", 40.0f);
        Invoke("SpawnEnemy3", 40.8f);
        Invoke("SpawnEnemy", 40.8f);
        Invoke("SpawnEnemy5", 41.7f);
        Invoke("SpawnEnemy4", 42.2f);
        Invoke("SpawnEnemy", 43.5f);
        Invoke("SpawnEnemy3", 44.4f);
        Invoke("SpawnEnemy", 46.0f);
        Invoke("SpawnEnemy1", 46.6f);
        Invoke("SpawnEnemy4", 47.9f);
        Invoke("SpawnEnemy", 48.8f);
        Invoke("SpawnEnemy", 49.8f);
        Invoke("SpawnEnemy4", 51.5f);
        Invoke("SpawnEnemy", 52.5f);
        Invoke("SpawnEnemy2", 53.3f);
        Invoke("SpawnEnemy", 54.2f);
        Invoke("SpawnEnemy5", 55.2f);
        Invoke("SpawnEnemy3", 57.0f);
        Invoke("SpawnEnemy", 57.9f);
        Invoke("SpawnEnemy2", 59.6f);
        Invoke("SpawnEnemy1", 60.6f);
        Invoke("SpawnEnemy4", 61.3f);
        Invoke("SpawnEnemy2", 62.3f);
        Invoke("SpawnEnemy", 63.1f);
        Invoke("SpawnEnemy3", 63.9f);
        Invoke("SpawnEnemy", 63.9f);
        Invoke("SpawnEnemy", 65.8f);
        Invoke("SpawnEnemy5", 66.8f);
        Invoke("SpawnEnemy", 67.3f);
        Invoke("SpawnEnemy", 68.5f);
        Invoke("SpawnEnemy1", 69.0f);
        Invoke("SpawnEnemy4", 69.5f);
        Invoke("SpawnEnemy2", 70.4f);
        Invoke("SpawnEnemy", 71.3f);
        Invoke("SpawnEnemy", 72.3f);
        Invoke("SpawnEnemy5", 73.4f);
        Invoke("SpawnEnemy", 74.9f);
        Invoke("SpawnEnemy2", 75.8f);
        Invoke("SpawnEnemy", 76.7f);
        Invoke("SpawnEnemy", 77.5f);
        Invoke("SpawnEnemy4", 78.0f);
        Invoke("SpawnEnemy3", 78.5f);
        Invoke("SpawnEnemy", 78.5f);
        Invoke("SpawnEnemy", 80.2f);
        Invoke("SpawnEnemy1", 81.1f);
        Invoke("SpawnEnemy", 82.0f);
        Invoke("SpawnEnemy", 83.8f);
        Invoke("SpawnEnemy5", 84.6f);
        Invoke("SpawnEnemy2", 85.6f);
        Invoke("SpawnEnemy", 86.4f);
        Invoke("SpawnEnemy4", 87.4f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
