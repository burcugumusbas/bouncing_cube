using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cubyMove : MonoBehaviour
{
    public float movespeed;
    private float horizontalmove;
    Rigidbody2D rb;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update(){
        horizontalmove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalmove*movespeed*Time.deltaTime, rb.velocity.y);

        
    }



    
}
