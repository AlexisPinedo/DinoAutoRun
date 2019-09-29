using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;

    [SerializeField] private float jumpForce;

    [SerializeField] private float fallMultiplier = 2.5f;

    [SerializeField] private float lowJumpMultiplier = 2f;
    
    [SerializeField] private float playerSpeed = 2f;

    public static bool playerLanded;

    private void Awake()
    {
        playerRigidBody = GetComponentInChildren<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAutoRun();
//        if (playerRigidBody.velocity.y < 0)
//        {
//            playerRigidBody.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
//        }
//        else if (playerRigidBody.velocity.y > 0 && Input.GetButton("Jump"))
//        {
//            playerRigidBody.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
//
//        }
    }

    void PlayerAutoRun()
    {
        playerRigidBody.velocity = Vector2.right * playerSpeed;
    }

}
