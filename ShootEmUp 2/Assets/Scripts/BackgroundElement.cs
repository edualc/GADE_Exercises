using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundElement : MonoBehaviour
{
    private float vx = 0.0f;
    private Rigidbody rigidBody;
    private float timeToLive = 25.0f;
    public int health = 4;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Destroy(this.gameObject, timeToLive);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        handleMovement();
    }

    public void registerHit()
    {
        health -= 1;
        if (health <= 0) {
            Destroy(this.gameObject);
        }
    }

    void handleMovement()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        pos.x += vx;

        rigidBody.MovePosition(pos);
    }
}
