using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject creditPannel;
    bool isOpen = false;

    private void Start()
    {
        creditPannel.SetActive(false);
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void CreditPannel()
    {
        isOpen = !isOpen;
        creditPannel.SetActive(isOpen);
    }
}
