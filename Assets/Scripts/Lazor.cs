using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazor : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject Lazor1;
    void Spawnlazor()
    {
        if (enableSpawn)
        {
            GameObject lazor = (GameObject)Instantiate(Lazor1, new Vector3(-3f, 1.6f, 0f), Quaternion.identity);
            Destroy(lazor,1.1f);
        }

    }
    // Use this for initialization
    void Start () {
        Invoke("Spawnlazor", 68.7f);
        
        Invoke("Spawnlazor", 70.4f);
        
        Invoke("Spawnlazor", 72.1f);
        
        Invoke("Spawnlazor", 73.8f);
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}


