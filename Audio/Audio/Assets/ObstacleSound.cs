using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSound : MonoBehaviour
{
  public AudioClip clip;
  private AudioSource audioSource;

  void Start()
  {
    audioSource = GetComponent<AudioSource>();
  }        

  void OnTriggerEnter(Collider other) {
    audioSource.playOnAwake = false;
    
    if (audioSource.clip == null) {
      audioSource.clip = clip;
    }

    audioSource.Play();
  }
}
