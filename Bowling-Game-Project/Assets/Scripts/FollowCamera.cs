using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform bowlingBall;

    private void LateUpdate()
    {
        transform.position =
            new Vector3(
                transform.position.x,
                transform.position.y,
                bowlingBall.position.z - 2.35f);
    }
}
