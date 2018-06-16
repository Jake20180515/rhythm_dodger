using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thanos : MonoBehaviour
{
    public Vector2 position1 = new Vector2(0,0);
    public static float time;
 
    // Use this for initialization

    void Start()
    {
        time = 55f;
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    private void Awake()
    {

    }
    // Update is called once per frame
  void Update()
    {
        if (time != 0)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                gameObject.GetComponent<Renderer>().enabled = true;
                transform.position=Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), position1, 2 * Time.deltaTime);
            }
        }
    }
}