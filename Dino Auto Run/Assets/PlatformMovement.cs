using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    private Rigidbody2D platformRigidbody2D;
    
    
    [SerializeField]
    private float platformSpeed = 5;
    

    private void Awake()
    {
        platformRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * platformSpeed * Time.timeScale;
        
        //platformRigidbody2D.velocity = Vector2.left * platformSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        PlayerMovement.playerLanded = true;
        Debug.Log("landed");
    }
}
