using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject ballHeighlight;
    [SerializeField] float maxRightDistance;
    [SerializeField] float maxLeftDistance;
    [SerializeField] AudioSource audioSource;

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
        MoveForwardWithKeyboardInputs();
        MoveLeftAndRight();
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            audioSource.Stop();
        }
    }

    private void MoveForwardWithKeyboardInputs()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(ballHeighlight);
            audioSource.Play();
            rb.AddForce(Vector3.forward * moveSpeed, ForceMode.Impulse);
            //rb.velocity = Vector3.forward * moveSpeed;
            
        }
    }

    private void MoveLeftAndRight()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            ballPosition.x += 0.1f;
            transform.position = ballPosition;

            if(ballPosition.x > maxRightDistance)
            {
                ballPosition.x = maxRightDistance;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ballPosition.x -= 0.1f;
            transform.position = ballPosition;

            if (ballPosition.x < maxLeftDistance)
            {
                ballPosition.x = maxLeftDistance;
            }
        }
    }

    private void MoveForwardWithTouchInputs()
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
}
