using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public Vector3 pos;
    public float speed = 18f;

    private void Awake()
    {
        pos = new Vector3(130f, 0, 0);
    }

    private void FixedUpdate()
    {
        this.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        if (this.pos.x == -30f)
            Destroy(this.gameObject);
    }
}