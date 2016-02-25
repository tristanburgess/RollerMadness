using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class OnBumperCollision : MonoBehaviour
{
    public AudioClip impact;
    new AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        audio.PlayOneShot(impact, 0.7F);
    }
}