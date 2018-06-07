using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    public Vector3 pos;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
    private void Awake()
    {
        pos = new Vector3(130f, 0, 0);
        speed = 0.25f; 
    }

    void move()
    {
        float xMove = speed;
        transform.Translate(-xMove, 0, 0);
        if (transform.position.x < -130f)
            Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        move();
    }
}
