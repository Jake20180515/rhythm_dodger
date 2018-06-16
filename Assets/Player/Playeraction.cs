using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Playeraction : MonoBehaviour {

    public float jumpSpeed = 15f;
    public Sprite sliding;
    public int jumpCount = 2;  
    bool isGrounded ;
    Animator anim;
    

    void Start()
    {
        jumpCount = 0;
       
        
    }
    void Awake()
    {

        anim = gameObject.GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D col)

    {

        if (col.gameObject.tag == "Ground")

        {   
            isGrounded = true;   
            jumpCount = 2;
        }
        

    }

    void Update()
    {
        if (isGrounded)
        {
            if (jumpCount > 0)

            {

                if (Input.GetKeyDown(KeyCode.Space))

                {

                    transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 10, 0) * jumpSpeed, ForceMode2D.Impulse);
                    anim.SetTrigger("JumpMotion");
                    jumpCount--;
                    
                }
                
            }
         
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                anim.SetTrigger("SlideMotion");

            }
        }
   
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (Input.GetKey(KeyCode.E)){

            }
            else{
                Score.score -= 1;
            }
            if (Score.score == 0){
                // player object 파괴
                Destroy(this.gameObject);
            }
        }
    }

}
