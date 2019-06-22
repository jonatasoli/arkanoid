using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHorizontalPhysicsMovimentBehaviour : MonoBehaviour
{
    public float speedy = 1.5f;

    public float paddleLimit = 6.90f;

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
            currentPosition.x += speedy;

        if (Input.GetKey(KeyCode.LeftArrow))
            currentPosition.x -= speedy;
        
        if (currentPosition.x >= -paddleLimit && currentPosition.x <= paddleLimit)
            GetComponent<Rigidbody2D>().MovePosition(currentPosition);

    }
}
