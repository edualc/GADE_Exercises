using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shpere : MonoBehaviour
{
  public bool isGood = false;
  public float time = 10.0f;
  private Player player;
  public Rigidbody rb;

  void Start() {
    player = GameObject.FindWithTag("Player").GetComponent<Player>();
    rb = GetComponent<Rigidbody>();
  }

  void FixedUpdate()
  {
    if (rb.velocity.magnitude <= 0.1) {
      if (isGood) {
        player.increaseScore();
      }

      Destroy(this.gameObject);
    }
  }

  void OnTriggerExit(Collider other) {
    if (other.gameObject.tag == "Checkpoint") {
      isGood = false;
    }
  }

  void OnTriggerEnter(Collider other) {
    if (other.gameObject.tag == "Checkpoint") {
      isGood = true;
    }
  }
}
