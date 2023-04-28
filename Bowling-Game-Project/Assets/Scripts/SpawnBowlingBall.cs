using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBowlingBall : MonoBehaviour
{
    [SerializeField] GameObject blueBowlingBall;
    [SerializeField] GameObject redBowlingBall;
    [SerializeField] GameObject yellowBowlingBall;
    [SerializeField] GameObject darkBlueBowlingBall;
    [SerializeField] GameObject pinkBowlingBall;
    [SerializeField] GameObject purpleBowlingBall;
    [SerializeField] GameObject orangeBowlingBall;
    [SerializeField] GameObject cyanBowlingBall;
    [SerializeField] GameObject greenBowlingBall;

    [SerializeField] Vector3 bowlingBallSpawnPosition;

    private void Start()
    {
        SpawnSelectedBowlingBall();
    }

    private void SpawnSelectedBowlingBall()
    {
        if(BallSelect.selectedBallNumber == 1)
        {
            Instantiate(redBowlingBall, bowlingBallSpawnPosition, redBowlingBall.transform.rotation);
        }
        else if (BallSelect.selectedBallNumber == 2)
        {
            Instantiate(blueBowlingBall, bowlingBallSpawnPosition, blueBowlingBall.transform.rotation);
        }
        else if (BallSelect.selectedBallNumber == 3)
        {
            Instantiate(yellowBowlingBall, bowlingBallSpawnPosition, yellowBowlingBall.transform.rotation);
        }
        else if (BallSelect.selectedBallNumber == 4)
        {
            Instantiate(purpleBowlingBall, bowlingBallSpawnPosition, purpleBowlingBall.transform.rotation);
        }
        else if (BallSelect.selectedBallNumber == 5)
        {
            Instantiate(cyanBowlingBall, bowlingBallSpawnPosition, cyanBowlingBall.transform.rotation);
        }
        else if (BallSelect.selectedBallNumber == 6)
        {
            Instantiate(greenBowlingBall, bowlingBallSpawnPosition, greenBowlingBall.transform.rotation);
        }
        else if (BallSelect.selectedBallNumber == 7)
        {
            Instantiate(pinkBowlingBall, bowlingBallSpawnPosition, pinkBowlingBall.transform.rotation);
        }
        else if (BallSelect.selectedBallNumber == 8)
        {
            Instantiate(orangeBowlingBall, bowlingBallSpawnPosition, orangeBowlingBall.transform.rotation);
        }
        else if (BallSelect.selectedBallNumber == 9)
        {
            Instantiate(darkBlueBowlingBall, bowlingBallSpawnPosition, darkBlueBowlingBall.transform.rotation);
        }
    }
}
