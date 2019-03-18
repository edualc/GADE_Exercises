using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundElement : MonoBehaviour
{
    public float vx = -0.15f;
    private Rigidbody rigidBody;
    private float timeToLive = 25.0f;

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

    void handleMovement()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        pos.x += vx;

        rigidBody.MovePosition(pos);
    }
}
