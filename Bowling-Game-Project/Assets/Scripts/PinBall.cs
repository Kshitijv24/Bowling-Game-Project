using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PinBall : MonoBehaviour
{
    private static int noOfPinBall = 0;

    [SerializeField] AudioSource audioSource;
    [SerializeField] TextMeshProUGUI youWinText;

    private void Start()
    {
        youWinText.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            audioSource.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            noOfPinBall++;
            
            if(noOfPinBall == 4)
            {
                youWinText.enabled = true;
            }
        }
    }
}
