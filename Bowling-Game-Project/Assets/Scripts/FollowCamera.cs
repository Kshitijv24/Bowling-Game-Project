using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    BowlingBall bowlingBall;

    private void Start()
    {
        bowlingBall = FindObjectOfType<BowlingBall>();
    }

    private void LateUpdate()
    {
        transform.position =
            new Vector3(
                transform.position.x,
                transform.position.y,
                bowlingBall.transform.position.z - 2.35f);
    }
}
