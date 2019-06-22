using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBallBehaviour : MonoBehaviour
{
    public float startSpeedy = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = (Vector2.up + Vector2.right) * startSpeedy;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
