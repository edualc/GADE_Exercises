using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    private float vx = 0.0f;
    private float vy = 0.0f;
    private float gravity = 0.002f;
    private float xLimit = 0.25f;
    private float yLimit = 0.25f;
    private float speed = 0.005f;
    private float windSpeed = 0.0003f;
    private Boolean doGravity = false;
    private Boolean doWind = false;

    // Use this for initialization
    void Start() {
        //transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate() {
        HandleKeyInput();
        HandleGravity();
        HandleWind();

        // Update position
        transform.Translate(vx, vy, 0f);
    }

    private void OnCollisionEnter(Collision c) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    private void toggleGravity() {
        doGravity = !doGravity;
    }

    private void toggleWind() {
        doWind = !doWind;
    }

    private void HandleGravity() {
        if (doGravity) {
            vy = vy - gravity;
        }
    }

    private void HandleWind() {
        if (doWind) {
            vx = vx + (transform.position.y * windSpeed);
        }
    }

    private void HandleKeyInput()
    {
        if (Input.GetKey(KeyCode.W)) {
            vy = vy + speed;
        }
        if (Input.GetKey(KeyCode.S)) {
            vy = vy - speed;
        }
        if (Input.GetKey(KeyCode.A)) {
            vx = vx - speed;
        }
        if (Input.GetKey(KeyCode.D)) {
            vx = vx + speed;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            toggleGravity();
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt)) {
            toggleWind();
        }

        Mathf.Clamp(vx, -xLimit, xLimit);
        Mathf.Clamp(vy, -yLimit, yLimit);
    }
}
