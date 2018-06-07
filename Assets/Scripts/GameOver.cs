using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    bool is_over ;

	// Use this for initialization
	void Start () {
        is_over = false;
    }
	
    void game_over()
    {
        //transform.Translate(0, -10, 0);
        if (Score.score < 1&& !is_over )
            transform.Translate(0, -1, 0);

        if (transform.position.y < 10)
            is_over = true;
        
    }

	// Update is called once per frame
	void Update () {
        game_over();

    }
}
