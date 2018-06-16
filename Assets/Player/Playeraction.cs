using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Playeraction : MonoBehaviour {
    public static float time;
    public float jumpSpeed = 15f;
    public Sprite sliding;
    public int jumpCount = 2;  
    bool isGrounded ;
<<<<<<< HEAD
    
=======
    bool invincible=false;
>>>>>>> 98ec01d5b144d7595f25ca78db06087118a8f391
    Animator anim;
    

    void Start()
    {
        jumpCount = 0;
        
        time = 2f;
        


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

    //bool iscol;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Enemy")
        {
<<<<<<< HEAD
            Score.score -= 1;

            if (Input.GetKey(KeyCode.E)){

            }

            if (Score.score == 0)
            {
=======
            
            if (Input.GetKey(KeyCode.E)){

            }
            else
            {
                Score.score -= 1;
                Destroy(Score.herat_object[Score.score]);
                Score.h_x -= 2;
                //iscol = true;
                StartCoroutine("colstop");
            }


            if (Score.score == 0){
>>>>>>> 98ec01d5b144d7595f25ca78db06087118a8f391
                // player object 파괴
                Destroy(this.gameObject);
            }

        }
        if (collision.gameObject.tag == "AddHeart")
        {
            if (Score.score < 5)
            {
                Score.herat_object[(Score.score)] = Instantiate(GameObject.Find("Heart"), new Vector3(Score.h_x, Score.h_y), Quaternion.identity) as GameObject;
                Score.h_x += 2;
                Score.score += 1;

            }

            collision.gameObject.transform.position = (new Vector3(100, 100, 0)); // 충돌 일어나면 다른 장소로 이동 -> 숨기기

        }

    }


    /// <summary>
    /// 피격시 반짝
    /// </summary>
    public SpriteRenderer sr;
    IEnumerator colstop()
    {
        sr = GetComponent<SpriteRenderer>();
        int count = 0;
        while (count < 10)
        {
            if (count % 2 == 0)
                sr.color = new Color32(255, 255, 255, 60);
            else
                sr.color = new Color32(255, 255, 255, 255);

            yield return new WaitForSeconds(0.1f);
            count++;
        }
        sr.color = new Color32(255, 255, 255, 255);
        //iscol = false;

        yield return null;
    }

}
