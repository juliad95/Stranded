using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Audioclip muss an AudioSource angehängt sein.
public class PlaySound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
    }
}
