using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class InputHorizontalMovimentBehaviour : MonoBehaviour
    {
        public float speedy = 0.5f;
        public float paddleLimit = 7.40f;

        // Update is called once per frame
        void Update()
        {
            Vector2 currentPosition = transform.position;
            if (Input.GetKey(KeyCode.RightArrow))
                currentPosition.x += speedy;
            else if (Input.GetKey(KeyCode.LeftArrow))
                currentPosition.x -= speedy;

            if(currentPosition.x > -paddleLimit && currentPosition.x < paddleLimit)
                transform.position = currentPosition;
        }
    }