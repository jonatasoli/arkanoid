using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionSoundBehaviour : MonoBehaviour
{
    public AudioSource soundFXWall;

    public AudioSource soundFXBrickHit;

    public AudioSource souundFXBrickBroken;

    public AudioSource soundTrack;
    // Start is called before the first frame update
    void Start()
    {
        soundTrack.Play();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Wall" || collision.collider.tag == "Paddle")
            soundFXWall.Play();
        else if (collision.collider.tag == "Brick")
            if (collision.collider.GetComponent<BrickCrackBehaviour>().getLife < 1)
                soundFXBrickHit.Play();
            else
                souundFXBrickBroken.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
