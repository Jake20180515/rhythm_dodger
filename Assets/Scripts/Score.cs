using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public static int score;
    public static GameObject[] herat_object;  // 하트 오브젝트 배열
    public static float h_x;  // 하트 생성 위치 
    public static float h_y;  // 하트 생성 위치
    float timer = 0;
    GameObject add_heart;

    private void Awake()
    {
        
        score = 5;
        h_x = -24;
        h_y = 21;
        add_heart = new GameObject();
        herat_object = new GameObject[score];
        for (int i = 0; i < score; i++)
        {
            // 하트 생성
            herat_object[i] = Instantiate(GameObject.Find("Heart"), new Vector3(h_x, h_y), Quaternion.identity) as GameObject;
            h_x += 2;
        }
        score = 5;
    }
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 10)
        {
            add_heart = Instantiate(GameObject.Find("add_heart"), new Vector3(30, 10), Quaternion.identity) as GameObject;

            timer -= 10;
        }
        add_heart.transform.Translate(-18f* Time.deltaTime, 0, 0);

    }
}
