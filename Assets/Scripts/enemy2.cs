﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{

    public Vector3 pos;
    public float timer;
    public float speed = 18f;
    // Use this for initialization
    void Start()
    {

    }
    private void Awake()
    {
       // pos = new Vector3(130f, 15, 0);
     //   transform.position = pos;
    }

    void move()
    {

        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

        timer += Time.deltaTime;

        if (timer >= 1)
        {
            transform.localScale = new Vector3(4.17f, 5.43f, 0);
            timer = 0;
        }

        else if (timer >= 0.5)
        {
            transform.localScale = new Vector3(4.17f, 15.8f, 0);
            //timer = 0;
        }

        if (transform.position.x < -130f)
            Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
}
