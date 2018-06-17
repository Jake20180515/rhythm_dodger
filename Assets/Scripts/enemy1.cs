using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{

    public Vector3 pos;
    public float speed = 22f;
    public float s;
    // Use this for initialization
    void Start()
    {

    }
    private void Awake()
    {
        pos = new Vector3(130f, 0, 0);
        s = 0.5f;
    }

    void move()
    {
        if (transform.position.y >= 20)
            s = -0.20f;
        else if (transform.position.y <= 2)
            s = 0.20f;
        transform.Translate(-speed * Time.deltaTime, s, 0);


        if (transform.position.x < -130f)
            Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
}
