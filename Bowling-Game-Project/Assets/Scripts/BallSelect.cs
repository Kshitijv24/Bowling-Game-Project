using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSelect : MonoBehaviour
{
    //public static BallSelect Instance;

    //private void Awake()
    //{
    //    if(Instance == null)
    //    {
    //        Instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    public static int selectedBallNumber;

    public void SelectRedBall()
    {
        selectedBallNumber = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectBlueBall()
    {
        selectedBallNumber = 2;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectYellowBall()
    {
        selectedBallNumber = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectPurpleBall()
    {
        selectedBallNumber = 4;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectCyanBall()
    {
        selectedBallNumber = 5;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectGreenBall()
    {
        selectedBallNumber = 6;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectPinkBall()
    {
        selectedBallNumber = 7;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectOrangeBall()
    {
        selectedBallNumber = 8;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectDarkBlueBall()
    {
        selectedBallNumber = 9;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
