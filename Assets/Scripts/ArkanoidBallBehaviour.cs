﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArkanoidBallBehaviour : MonoBehaviour
{
    public float startSpeedy = 10;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = (Vector2.up + Vector2.right) * startSpeedy;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.onBallCollision(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.onBallCollision(other.gameObject);
    }
}