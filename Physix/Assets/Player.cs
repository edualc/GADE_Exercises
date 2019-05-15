using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
  public Camera cam;
  public GameObject sphere;
  public Text text;
  public int score = 0;

  public void increaseScore() {
    score++;
    text.text = "Current score: " + score;
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(0)) {
      RaycastHit hit; 
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      if ( Physics.Raycast (ray,out hit,100.0f)) {
        GameObject newSphere = Instantiate(sphere, transform.position, Quaternion.identity);

        newSphere.GetComponent<Rigidbody>().velocity = (hit.point - this.transform.position) * 3.0f;
      }
    }
  }
}
