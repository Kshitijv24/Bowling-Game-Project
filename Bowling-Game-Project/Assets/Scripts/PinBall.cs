using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBall : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground")
        {
            audioSource.Play();
        }
    }
}
