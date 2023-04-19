using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject ballHeighlight;

    Vector2 startTouchPosition;
    Vector2 fingerDownPosition;
    Vector2 fingerUpPosition;
    float minSwipeDistance = 50f;
    Vector3 ballPosition;

    private void Start()
    {
        ballPosition = transform.position;
    }

    private void Update()
    {
        MoveForwardDesktop();
        MoveLeftAndRight();
    }

    private void MoveForwardDesktop()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * moveSpeed, ForceMode.Impulse);
            Destroy(ballHeighlight);
        }
    }

    private void MoveForwardAndroid()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            fingerDownPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            fingerUpPosition = Input.GetTouch(0).position;

            if (Vector2.Distance(fingerDownPosition, fingerUpPosition) > minSwipeDistance)
            {
                Vector2 swipeDirection = fingerUpPosition - fingerDownPosition;
                swipeDirection = new Vector2(swipeDirection.y, swipeDirection.x); // Swap X and Y components
                rb.AddForce(swipeDirection.normalized * moveSpeed, ForceMode.Impulse);
            }
        }
    }

    private void MoveLeftAndRight()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            ballPosition.x += 0.1f;
            transform.position = ballPosition;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ballPosition.x -= 0.1f;
            transform.position = ballPosition;
        }
    }
}
