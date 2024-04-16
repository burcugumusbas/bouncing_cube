using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    public float jumpForce;
    public bool touchedfloor;
    Animator animation;
    int doublejump;

    private void Start(){
        animation = GetComponent<Animator>();
        doublejump = Random.Range(1,11);

        if(doublejump==1){
            animation.SetBool("doublejump", true);
            jumpForce = 40f;
        }
        else{
            jumpForce = 20f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){


        if(collision.relativeVelocity.y < 0 ){

             Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

        if (rb!= null){
            Vector2 jumpVelocity = rb.velocity;
            jumpVelocity.y = jumpForce;
            rb.velocity = jumpVelocity;

            if(touchedfloor==false){
                Admin.scorePoint++;
                touchedfloor = true;
                

            }

            animation.SetBool("Touched", true);
            Destroy(gameObject,0.3f);

        }


        }

       

    }
}
