using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundElement : MonoBehaviour
{
    public float vx = -0.2f;
    private Rigidbody rigidBody;
    private float timeToLive = 25.0f;
    public float scrollSpeedX = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Destroy(this.gameObject, timeToLive);
        vx = vx + Random.Range(-0.1f, 0.1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        handleMovement();
    }

    void handleMovement()
    {
        Vector3 pos = new Vector3(transform.position.x + scrollSpeedX, transform.position.y, transform.position.z);
        pos.x += vx;

        rigidBody.MovePosition(pos);
    }
}
