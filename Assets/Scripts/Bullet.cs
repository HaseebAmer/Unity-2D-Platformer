using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : EntityMovement
{
    [SerializeField] float projectileSpeed = 20f;
    PlayerMovement player;
    float horizontalSpeed;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        horizontalSpeed = player.transform.localScale.x * projectileSpeed;
    }

    void Update()
    {
        myRigidbody.velocity = new Vector2 (horizontalSpeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Destroy(gameObject);    
    }

}
