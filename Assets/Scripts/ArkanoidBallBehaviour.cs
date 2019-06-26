using System;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GameOver"))
            SceneManager.LoadScene(2);
        else if (other.CompareTag("SpecialItem"))
            gameManager.onSpecialItemCollision(other.gameObject);
    }
}