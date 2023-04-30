using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform rightSide, leftSide;
    [SerializeField] float moveSpeed;

    Vector3 rightSidePosition;
    Vector3 leftSidePosition;
    bool canMove = true;

    private void Awake()
    {
        rb.useGravity = false;
    }

    private void Start()
    {
        rightSidePosition = rightSide.position;
        leftSidePosition = leftSide.position;
    }

    private void Update()
    {
        if(!rb.useGravity)
            MoveingPinLeftAndRight();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            rb.useGravity = true;
        }
    }

    private void MoveingPinLeftAndRight()
    {
        if (transform.position != rightSidePosition && canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, rightSidePosition, moveSpeed * Time.deltaTime);

            if (transform.position == rightSidePosition)
                canMove = false;
        }

        if (transform.position != leftSidePosition && !canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, leftSidePosition, moveSpeed * Time.deltaTime);

            if (transform.position == leftSidePosition)
                canMove = true;
        }
    }
}
